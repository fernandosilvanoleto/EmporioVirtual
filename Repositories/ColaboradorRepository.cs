using EmporioVirtual.Database;
using EmporioVirtual.Models;
using EmporioVirtual.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Repositories
{
    public class ColaboradorRepository : IColaboradorRepository
    {
        private EmporioVirtualContext _banco;

        // injenção de dependência
        public ColaboradorRepository(EmporioVirtualContext banco)
        {
            _banco = banco;
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
            return _banco.Colaborador.ToList();
        }
    }
}
