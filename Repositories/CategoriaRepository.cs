using EmporioVirtual.Database;
using EmporioVirtual.Models;
using EmporioVirtual.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace EmporioVirtual.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        const int _registroPorPagina = 10;
        EmporioVirtualContext _banco;
        public CategoriaRepository(EmporioVirtualContext banco)
        {
            _banco = banco;
        }
        public void Atualizar(Categoria categoria)
        {
            _banco.Update(categoria);
            _banco.SaveChanges();
        }

        public void Cadastrar(Categoria categoria)
        {
            _banco.Add(categoria);
            _banco.SaveChanges();
        }

        public void Excluir(int id)
        {
            Categoria categoria = ObterCategoria(id);
            _banco.Remove(categoria);
            _banco.SaveChanges();
        }

        public Categoria ObterCategoria(int id)
        {
            return _banco.Categoria.Find(id);
        }

        public IPagedList<Categoria> ObterTodosCategorias(int? pagina)
        {
            // se pagina for igual a null, atribui o valor padrão 1
            int numeroPagina = pagina ?? 1;
            return _banco.Categoria.Include(a=>a.CategoriaPai).ToPagedList<Categoria>(numeroPagina, _registroPorPagina);
        }
    }
}
