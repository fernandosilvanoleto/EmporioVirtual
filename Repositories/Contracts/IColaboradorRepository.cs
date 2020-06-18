using EmporioVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace EmporioVirtual.Repositories.Contracts
{
    public interface IColaboradorRepository
    {
        Colaborador Login(string Email, string Senha);
        void Cadastrar(Colaborador colaborador);
        void Atualizar(Colaborador colaborador);
        void Excluir(int id);
        Colaborador ObterColaborador(int id);
        IEnumerable<Colaborador> ObterColaboradores();

        IPagedList<Colaborador> ObterTodosColaboradores(int? pagina);

    }
}
