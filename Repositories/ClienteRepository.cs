using EmporioVirtual.Database;
using EmporioVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private EmporioVirtualContext _banco;
        public ClienteRepository(EmporioVirtualContext banco)
        {
            _banco = banco;
        }
        public void Atualizar(Cliente cliente)
        {
            _banco.Update(cliente);
            _banco.SaveChanges();
        }

        public void Cadastrar(Cliente cliente)
        {
            _banco.Add(cliente);
            _banco.SaveChanges();
        }

        public void Excluir(int id)
        {
            Cliente cliente = ObterCliente(id);
            _banco.Remove(cliente);
            _banco.SaveChanges();
        }

        public Cliente Login(string Email, string Senha)
        {
            Cliente cliente = _banco.Clientes.Where(c => c.Email == Email && c.Senha == Senha).FirstOrDefault();
            return cliente;
        }

        public Cliente ObterCliente(int id)
        {
            return _banco.Clientes.Find(id);
        }

        public List<Cliente> ObterTodosClientes()
        {
            return _banco.Clientes.ToList();
        }
    }
}
