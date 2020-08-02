using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace EmporioVirtual.Models.ViewModels
{
    public class ProdutoListagemViewModel
    {
        public IPagedList<Produto> Lista { get; set; }
        public List<SelectListItem> Ordenacao
        {
            get
            {
                return new List<SelectListItem>()
                {
                    new SelectListItem("Alfabetica", "A"),
                    new SelectListItem("Menor Preço", "ME"),
                    new SelectListItem("Maior preço", "MA"),
                };
            }
            private set { }
        }
    }
}
