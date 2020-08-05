using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmporioVirtual.Models;
using EmporioVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace EmporioVirtual.Controllers
{
    public class ProdutoController : Controller
    {
        private ICategoriaRepository _categoriaRepository;
        private IProdutoRepository _produtoRepository;
        public ProdutoController(ICategoriaRepository categoriarepository, IProdutoRepository produtorepository)
        {
            _categoriaRepository = categoriarepository;
            _produtoRepository = produtorepository;
        }

        //Protudo/ListagemCategoria/informatica        
        [HttpGet]
        [Route("/Produto/Categoria/{slog}")]
        public IActionResult ListagemCategoria(string slog)
        {
            //TODO - Criar algoritmo recursivo que obtem uma lista com todas as categorias que devem utilizadas para apresentar o produto
            Categoria CategoriaPrincipal = _categoriaRepository.ObterCategoria(slog);

            List<Categoria> lista = _categoriaRepository.ObterCategoriasRecursivas(CategoriaPrincipal).ToList();

            ViewBag.Categorias = lista;

            //TODO - Adaptar o ProdutoRepository para receber uma lista de categoria e filtrar os produtos baseado na lista
            
            
            return View();
        }

        
        /* ---------------------------------------------- */

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Visualizar()
        {
            Produto produto = GetProduto();


            return View(produto);
            //return new ContentResult() { Content = "<h2>Notebook Dell - 15 300</h2>", ContentType = "text/html" };
        }

        private Produto GetProduto()
        {
            return new Produto()
            {
                Id = 1,
                Nome = "Dell 15 300",
                Descricao = "Notebook da Dell",
                Valor = 4731.31M
            };
        }

    }
}