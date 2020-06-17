using EmporioVirtual.Libraries.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Models
{
    public class Categoria
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(2, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E002")]
        //TODO: Criar validação - Nome categoria único
        public string Nome { get; set; }

        /*
         * Slog
         */
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(2, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E002")]
        public string Slog { get; set; }

        /*
         * Auto-Relacionamento
         * Hierarquia e criar subcategoria
         * int? permitir null em C#
         */
        [Display(Name = "Categoria Pai")]
        public int? CategoriaPaiId { get; set; }

        /*
         * ORM - Entity
         * FK do Entity Core
         */
        [ForeignKey("CategoriaPaiId")]
        public virtual Categoria CategoriaPai { get; set; }

    }
}
