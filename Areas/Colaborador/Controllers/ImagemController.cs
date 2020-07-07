using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmporioVirtual.Libraries.Arquivo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmporioVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    public class ImagemController : Controller
    {
        public IActionResult Armazenar(IFormFile file)
        {
            GerenciadorArquivo.CadastrarImagemProduto(file);
            return View();
        }

        public IActionResult Deletar()
        {
            return View();
        }
    }
}
