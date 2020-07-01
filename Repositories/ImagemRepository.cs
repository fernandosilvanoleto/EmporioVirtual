using EmporioVirtual.Database;
using EmporioVirtual.Models;
using EmporioVirtual.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Repositories
{
    public class ImagemRepository : IImagemRepository
    {
        private EmporioVirtualContext _banco;
        public ImagemRepository(EmporioVirtualContext banco)
        {
            _banco = banco;
        }
        public void Cadastrar(Imagem imagem)
        {
            _banco.Add(imagem);
            _banco.SaveChanges();
        }

        public void Excluir(int id)
        {
            Imagem imagem = _banco.Imagem.Find(id);
            _banco.Remove(imagem);
            _banco.SaveChanges();
        }

        public void ExcluirImagensdoProduto(int IdProduto)
        {
            List<Imagem> imagens = _banco.Imagem.Where(a => a.ProdutoId == IdProduto).ToList();

            foreach (Imagem imagem in imagens)
            {
                _banco.Remove(imagem);                
            }
            _banco.SaveChanges();
        }
    }
}
