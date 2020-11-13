using EmporioVirtual.Database;
using EmporioVirtual.Models;
using EmporioVirtual.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Repositories
{
    public class EnderecoEntregaRepository : IEnderecoEntregaRepository
    {
        private EmporioVirtualContext _banco;
        public EnderecoEntregaRepository(EmporioVirtualContext banco)
        {
            _banco = banco;
        }
        public void Atualizar(EnderecoEntrega endereco_entrega)
        {
            _banco.Update(endereco_entrega);
            _banco.SaveChanges();
        }

        public void Cadastrar(EnderecoEntrega endereco_entrega)
        {
            _banco.Add(endereco_entrega);
            _banco.SaveChanges();
        }

        public void Excluir(int id)
        {
            EnderecoEntrega enderecoEntrega = ObterEnderecoEntrega(id);
            _banco.Remove(enderecoEntrega);
            _banco.SaveChanges();
        }

        public EnderecoEntrega ObterEnderecoEntrega(int id)
        {
            return _banco.EnderecoEntrega.Find(id);
        }

        public IList<EnderecoEntrega> ObterTodosEnderecosEntregaCliente(int clienteId)
        {
            return _banco.EnderecoEntrega.Where(a => a.ClienteId == clienteId).ToList();
        }
    }
}
