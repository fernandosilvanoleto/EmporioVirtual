using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace EmporioVirtual.Models.ViewModels
{
    public class IndexViewModel
    {
        public NewsletterEmail Newsletter { get; set; }
        public IPagedList<Produto> Lista { get; set; }
    }
}
