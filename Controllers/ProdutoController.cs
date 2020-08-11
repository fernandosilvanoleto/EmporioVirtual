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
            //TODO - Adaptar o ProdutoRepository para receber uma lista de categoria e filtrar os produtos baseado na lista         
            return View(_categoriaRepository.ObterCategoria(slog));
        }

        
        /* ---------------------------------------------- */

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Visualizar(int id)
        {
            //Obter produto

            return View(_produtoRepository.ObterProduto(id));
        }

    }
}