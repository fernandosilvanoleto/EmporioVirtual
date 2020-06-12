using EmporioVirtual.Database;
using EmporioVirtual.Models;
using EmporioVirtual.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
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

        public IEnumerable<Categoria> ObterTodosCategorias()
        {
            return _banco.Categoria.ToList();
        }
    }
}
