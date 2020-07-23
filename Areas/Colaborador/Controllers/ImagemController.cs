using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmporioVirtual.Libraries.Arquivo;
using EmporioVirtual.Libraries.Filtro;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmporioVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    [ColaboradorAutorizacao]
    public class ImagemController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Armazenar(IFormFile file)
        {
            var Caminho = GerenciadorArquivo.CadastrarImagemProduto(file);

            if (Caminho.Length > 0)
            {
                // STATUS DO HTTP :: 200 - OK
                return Ok( new { caminho = Caminho }); //JSON
            }
            else
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpGet]
        public IActionResult Deletar(string caminho)
        {
            if (GerenciadorArquivo.ExcluirImagemProduto(caminho))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
