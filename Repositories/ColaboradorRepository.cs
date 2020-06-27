using EmporioVirtual.Database;
using EmporioVirtual.Models;
using EmporioVirtual.Models.Constants;
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
            //Atualiza o Nome - Email - Tipo
            _banco.Update(colaborador);
            // a senha ou qualquer campo colocado aqui não será atualizada quando fizer update
            _banco.Entry(colaborador).Property(a => a.Senha).IsModified = false;
            _banco.SaveChanges();
        }

        public void AtualizarSenha(Colaborador colaborador)
        {
            // Atualiza somente Senha do Colaborador
            _banco.Update(colaborador);
            // a senha ou qualquer campo colocado aqui não será atualizada quando fizer update
            _banco.Entry(colaborador).Property(a => a.Nome).IsModified = false;
            _banco.Entry(colaborador).Property(a => a.Email).IsModified = false;
            _banco.Entry(colaborador).Property(a => a.Tipo).IsModified = false;
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
            return _banco.Colaborador.Where(a => a.Tipo != ColaboradorTipoConstant.Gerente).ToPagedList<Colaborador>(numeroPagina, _configuration.GetValue<int>("RegistroPorPagina"));
        }

        public List<Colaborador> ObterColaboradorPorEmail(string email)
        {
            // não vai ter o objeto do banco acompanhado :)
            // AsNoTracking = correção de atualização do colaborador
            return _banco.Colaborador.Where(a => a.Email == email).AsNoTracking().ToList(); 
        }
    }
}
