using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        /*
         * Slog
         */
        public string Slog { get; set; }

        /*
         * Auto-Relacionamento
         * Hierarquia e criar subcategoria
         * int? permitir null em C#
         */
        public int? CategoriaPaiId { get; set; }

        /*
         * ORM - Entity
         * FK do Entity Core
         */
        [ForeignKey("CategoriaPaiId")]
        public virtual Categoria CategoriaPai { get; set; }

    }
}
