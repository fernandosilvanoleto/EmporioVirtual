using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmporioVirtual.Libraries.Lang;
using EmporioVirtual.Repositories.Contracts;
using EmporioVirtual.Models;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;
using EmporioVirtual.Libraries.Texto;

namespace EmporioVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    public class ColaboradorController : Controller
    {
        IColaboradorRepository _colaboradorrepository;
        public ColaboradorController(IColaboradorRepository colaboradorrepository)
        {
            _colaboradorrepository = colaboradorrepository;
        }

        public IActionResult Index(int? pagina)
        {
            IPagedList<Models.Colaborador> colaboradores = _colaboradorrepository.ObterTodosColaboradores(pagina);
            return View(colaboradores);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm]Models.Colaborador colaborador)
        {
            if (ModelState.IsValid)
            {

                //TODO: Implementar tabela de Tipo Colaborador
                colaborador.Tipo = "C";
                _colaboradorrepository.Cadastrar(colaborador);

                TempData["Mens_S"] = Mensagem.MSG_S001;

                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        public IActionResult GerarSenha(int id)
        {
            Models.Colaborador colaborador = _colaboradorrepository.ObterColaborador(id);
            colaborador.Senha = KeyGenerator.GetUnique(8);
            _colaboradorrepository.Atualizar(colaborador);


            //SALVAR SENHA E ENVIAR E-MAIL
        }

        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            // não importa do Models principal
            Models.Colaborador colaborador = _colaboradorrepository.ObterColaborador(id);
            return View(colaborador);
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm] Models.Colaborador colaborador, int id)
        {
            if (ModelState.IsValid)
            {
                _colaboradorrepository.Atualizar(colaborador);

                TempData["Mens_S"] = Mensagem.MSG_S001;

                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            _colaboradorrepository.Excluir(id);

            TempData["Mens_S"] = Mensagem.MSG_S002;

            return RedirectToAction(nameof(Index));
        }
    }
}
