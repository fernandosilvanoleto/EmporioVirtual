using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmporioVirtual.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmporioVirtual.Controllers
{
    public class ProdutoController : Controller
    {
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