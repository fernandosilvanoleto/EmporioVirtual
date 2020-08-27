using EmporioVirtual.Models.ProdutoAgregador;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Models
{
    public class Imagem
    {
        public int Id { get; set; }
        public string Caminho { get; set; }
        
        // BANCO DE DADOS
        public int ProdutoId { get; set; }

        //POO - Associação
        [ForeignKey("ProdutoId")]
        public virtual Produto Produto { get; set; }

    }
}
