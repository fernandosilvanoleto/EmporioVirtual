using EmporioVirtual.Database;
using EmporioVirtual.Models;
using EmporioVirtual.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace EmporioVirtual.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        const int _registroPorPagina = 10;
        private IConfiguration _configuration;
        private EmporioVirtualContext _banco;
        public ProdutoRepository(EmporioVirtualContext banco, IConfiguration configuration)
        {
            _banco = banco;
            _configuration = configuration;
        }
        public void Atualizar(Produto produto)
        {
            _banco.Update(produto);
            _banco.SaveChanges();
        }

        public void Cadastrar(Produto produto)
        {
            _banco.Add(produto);
            _banco.SaveChanges();
        }

        public void Excluir(int id)
        {
            Produto produto = ObterProduto(id);
            _banco.Remove(produto);
            _banco.SaveChanges();
        }

        public Produto ObterProduto(int id)
        {
            return _banco.Produto.Include(a => a.Imagens).Where(a => a.Id == id).FirstOrDefault() ;
        }

        public IPagedList<Produto> ObterTodosProdutos(int? pagina, string pesquisa)
        {
            int RegistroPorPagina = _configuration.GetValue<int>("RegistroPorPagina");

            int numeroPagina = pagina ?? 1;

            var bancoProduto = _banco.Produto.AsQueryable();

            if (!string.IsNullOrEmpty(pesquisa))
            {
                //NÃO ESTÁ VAZIO
                bancoProduto = bancoProduto.Where(a => a.Nome.Contains(pesquisa.Trim()));
            }

            return bancoProduto.Include(a => a.Imagens).ToPagedList<Produto>(numeroPagina, RegistroPorPagina);

        }
    }
}
