using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmporioVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmporioVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    public class ProdutoController : Controller
    {
        private IProdutoRepository _produtorepository;
        private ICategoriaRepository _categoriaRepository;
        public ProdutoController(IProdutoRepository produtorepository, ICategoriaRepository categoriaRepository)
        {
            _produtorepository = produtorepository;
            _categoriaRepository = categoriaRepository;
        }

        public IActionResult Index(int? pagina, string pesquisa)
        {
            var produtos = _produtorepository.ObterTodosProdutos(pagina, pesquisa);
            return View(produtos);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            ViewBag.Categorias = _categoriaRepository.ObterTodasCategoriasSelect().Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
            return View();
        } 
    }
}
