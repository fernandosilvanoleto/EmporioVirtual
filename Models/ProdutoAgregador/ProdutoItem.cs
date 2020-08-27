using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Models.ProdutoAgregador
{
    public class ProdutoItem : Produto
    {
        // campo armazena a quantidade de produto que o usuário queira comprar
        public int QuantidadeProdutoCarrinho { get; set; }

    }
}
