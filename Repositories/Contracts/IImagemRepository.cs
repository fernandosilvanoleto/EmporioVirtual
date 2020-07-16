using EmporioVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Repositories.Contracts
{
    public interface IImagemRepository
    {
        void CadastrarImagens(List<Imagem> ListaImagens, int produto_id);
        void Cadastrar(Imagem imagem);
        void Excluir(int id);
        void ExcluirImagensdoProduto(int IdProduto);
    }
}
