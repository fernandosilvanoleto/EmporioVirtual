using EmporioVirtual.Models;
using EmporioVirtual.Models.ViewModels;
using EmporioVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Libraries.Componente
{
    public class ProdutoListagemViewComponent : ViewComponent
    {
        private IProdutoRepository _produtoRepository;
        private ICategoriaRepository _categoriaRepository;
        public ProdutoListagemViewComponent(IProdutoRepository produtoRepository, ICategoriaRepository categoriaRepository)
        {
            _produtoRepository = produtoRepository;
            _categoriaRepository = categoriaRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            int? pagina = 1;
            string pesquisa = "";
            string ordenacao = "A";
            IEnumerable<Categoria> categorias = null;

            if (HttpContext.Request.Query.ContainsKey("pagina"))
            {
                pagina = int.Parse(HttpContext.Request.Query["pagina"]);
            }

            if (HttpContext.Request.Query.ContainsKey("pesquisa"))
            {
                pesquisa = HttpContext.Request.Query["pesquisa"].ToString();
            }

            if (HttpContext.Request.Query.ContainsKey("ordenacao"))
            {
                ordenacao = HttpContext.Request.Query["ordenacao"];
            }
            if (ViewContext.RouteData.Values.ContainsKey("slog"))
            {
                string slog = ViewContext.RouteData.Values["slog"].ToString();
                //Criar algoritmo recursivo que obtem uma lista com todas as categorias que devem utilizadas para apresentar o produto
                Categoria CategoriaPrincipal = _categoriaRepository.ObterCategoria(slog);

                categorias = _categoriaRepository.ObterCategoriasRecursivas(CategoriaPrincipal);

            }

            var ViewModel = new ProdutoListagemViewModel() { Lista = _produtoRepository.ObterTodosProdutos(pagina, pesquisa, ordenacao, categorias) };
            
            return View(ViewModel);
        }
    }
}
