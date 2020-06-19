using EmporioVirtual.Database;
using EmporioVirtual.Models;
using EmporioVirtual.Repositories.Contracts;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace EmporioVirtual.Repositories
{
    public class ColaboradorRepository : IColaboradorRepository
    {
        private EmporioVirtualContext _banco;
        private IConfiguration _configuration;

        // injenção de dependência
        public ColaboradorRepository(EmporioVirtualContext banco, IConfiguration configuration)
        {
            _banco = banco;
            _configuration = configuration;
        }
        public void Cadastrar(Colaborador colaborador)
        {
            _banco.Add(colaborador);
            _banco.SaveChanges();
        }

        public void Atualizar(Colaborador colaborador)
        {
            _banco.Update(colaborador);
            _banco.SaveChanges();
        }        

        public void Excluir(int id)
        {
            Colaborador cliente = ObterColaborador(id);
            _banco.Remove(cliente);
            _banco.SaveChanges();
        }

        public Colaborador Login(string Email, string Senha)
        {
            Colaborador colaborador = _banco.Colaborador.Where(c => c.Email == Email && c.Senha == Senha).FirstOrDefault();
            return colaborador;
        }

        public Colaborador ObterColaborador(int id)
        {
            return _banco.Colaborador.Find(id);
        }

        public IEnumerable<Colaborador> ObterColaboradores()
        {
            return _banco.Colaborador.Where(a=>a.Tipo != "G").ToList();
        }

        public IPagedList<Colaborador> ObterTodosColaboradores(int? pagina)
        {
            // se pagina for igual a null, atribui o valor padrão 1
            int numeroPagina = pagina ?? 1;
            return _banco.Colaborador.Where(a => a.Tipo != "G").ToPagedList<Colaborador>(numeroPagina, _configuration.GetValue<int>("RegistroPorPagina"));
        }
    }
}
