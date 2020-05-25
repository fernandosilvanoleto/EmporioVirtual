using EmporioVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Repositories
{
    interface IClienteRepository
    {
        Cliente Login(string Email, string Senha);
        
        void Cadastrar(Cliente cliente);
        void Atualizar(Cliente cliente);
        void Excluir(int id);
        Cliente ObterCliente(int id);
        List<Cliente> ObterTodosClientes();

    }
}
