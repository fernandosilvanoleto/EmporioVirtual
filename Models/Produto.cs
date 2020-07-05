using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Preço")]
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }

        // FRETE - CORREIOS
        public double Peso { get; set; }
        public int Largura { get; set; }       
        public int Altura { get; set; }
        public int Comprimento { get; set; }

        // EN - ORM = Biblioteca para unir POO e BANCO - MAPEAMENTO DE OBJETOS RELACIONAIS
        //Fluente API - ATTRIBUTES

        // banco - relacionamentos entre tabelas
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }

        // POO - Associações entre objetos
        [ForeignKey("CategoriaId")]
        public virtual Categoria Categoria { get; set; }

        public virtual ICollection<Imagem> Imagens { get; set; }

    }
}
