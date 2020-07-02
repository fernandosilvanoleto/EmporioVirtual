using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmporioVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace EmporioVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    public class ProdutoController : Controller
    {
        IProdutoRepository _produtorepository;
        public ProdutoController(IProdutoRepository produtorepository)
        {
            _produtorepository = produtorepository;
        }

        public IActionResult Index(int? pagina, string pesquisa)
        {
            var produtos = _produtorepository.ObterTodosProdutos(pagina, pesquisa);
            return View(produtos);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        } 
    }
}
