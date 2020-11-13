using EmporioVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace EmporioVirtual.Repositories.Contracts
{
    public interface IEnderecoEntregaRepository
    {
        void Cadastrar(EnderecoEntrega endereco_entrega);
        void Atualizar(EnderecoEntrega endereco_entrega);
        void Excluir(int id);
        EnderecoEntrega ObterEnderecoEntrega(int id);
        IList<EnderecoEntrega> ObterTodosEnderecosEntregaCliente(int clienteId);
    }
}
