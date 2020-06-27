using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmporioVirtual.Libraries.Filtro;
using EmporioVirtual.Libraries.Lang;
using EmporioVirtual.Models;
using EmporioVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;

namespace EmporioVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    [ColaboradorAutorizacao]
    public class CategoriaController : Controller
    {
        private ICategoriaRepository _categoriaRepository;

        public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
        public IActionResult Index(int? pagina, string nome)
        {
            /*
             * PAGINAÇÃO
             */
            var categorias = _categoriaRepository.ObterTodosCategorias(pagina);
            
            return View(categorias);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            ViewBag.Categorias = _categoriaRepository.ObterTodasCategoriasSelect().Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm]Categoria categoria )
        {
            if (ModelState.IsValid)
            {
                _categoriaRepository.Cadastrar(categoria);

                TempData["Mens_S"] = Mensagem.MSG_S001;

                return RedirectToAction(nameof(Index));
            }
            ViewBag.Categorias = _categoriaRepository.ObterTodasCategoriasSelect().Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
            return View();
        }

        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            var categoria = _categoriaRepository.ObterCategoria(id);
            ViewBag.Categorias = _categoriaRepository.ObterTodasCategoriasSelect().Where(a=>a.Id != id).Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
            return View(categoria);
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm]Categoria categoria, int id)
        {
            if (ModelState.IsValid)
            {
                _categoriaRepository.Atualizar(categoria);

                TempData["Mens_S"] = Mensagem.MSG_S001;

                return RedirectToAction(nameof(Index));
            }

            ViewBag.Categorias = _categoriaRepository.ObterTodasCategoriasSelect().Where(a => a.Id != id).Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
            return View();
        }

        [HttpGet]
        [ValidateHttpReferer]
        public IActionResult Excluir(int id)
        {
            _categoriaRepository.Excluir(id);
            TempData["Mens_S"] = Mensagem.MSG_S002;
            return RedirectToAction(nameof(Index));
        }
    }
}
