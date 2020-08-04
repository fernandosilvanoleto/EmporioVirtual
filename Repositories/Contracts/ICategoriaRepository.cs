using EmporioVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace EmporioVirtual.Repositories.Contracts
{
    public interface ICategoriaRepository
    {

        void Cadastrar(Categoria categoria);
        void Atualizar(Categoria categoria);
        void Excluir(int id);
        Categoria ObterCategoria(int id);
        Categoria ObterCategoria(string slog);
        IEnumerable<Categoria> ObterTodasCategoriasSelect();
        IPagedList<Categoria> ObterTodosCategorias(int? pagina);
    }
}
