using EmporioVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Libraries.Componente
{
    public class MenuViewComponent : ViewComponent
    {
        // INJEÇÃO DE DEPENDÊNCIA
        private ICategoriaRepository _categoriarepository;
        public MenuViewComponent(ICategoriaRepository categoriarepository)
        {
            _categoriarepository = categoriarepository;
        }

        // LÓGICA DE COMPONENTES
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var ListaCategoria = _categoriarepository.ObterTodasCategoriasSelect().ToList();

            //PASSANDO VIA MODELO
            return View(ListaCategoria);
        }
    }
}
