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
using EmporioVirtual.Libraries.Email;
using EmporioVirtual.Libraries.Filtro;
using EmporioVirtual.Models.Constants;

namespace EmporioVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    [ColaboradorAutorizacao(ColaboradorTipoConstant.Gerente)]
    public class ColaboradorController : Controller
    {
        private IColaboradorRepository _colaboradorrepository;
        private GerenciarEmail _gerenciaremail;
        public ColaboradorController(IColaboradorRepository colaboradorrepository, GerenciarEmail gerenciaremail)
        {
            _colaboradorrepository = colaboradorrepository;
            _gerenciaremail = gerenciaremail;
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
            ModelState.Remove("Senha");
            if (ModelState.IsValid)
            {

                //TODO: Implementar tabela de Tipo Colaborador
                colaborador.Tipo = ColaboradorTipoConstant.Comum;

                colaborador.Senha = KeyGenerator.GetUnique(8);

                _colaboradorrepository.Cadastrar(colaborador);

                _gerenciaremail.EnvarEmailParaColaboradorPorEmail(colaborador);

                TempData["Mens_S"] = Mensagem.MSG_S001;

                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        [ValidateHttpReferer]
        public IActionResult GerarSenha(int id)
        {
            Models.Colaborador colaborador = _colaboradorrepository.ObterColaborador(id);
            colaborador.Senha = KeyGenerator.GetUnique(8);
            _colaboradorrepository.AtualizarSenha(colaborador);

            _gerenciaremail.EnvarEmailParaColaboradorPorEmail(colaborador);

            TempData["Mens_S"] = Mensagem.MSG_S003;

            return RedirectToAction(nameof(Index));

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
            ModelState.Remove("Senha"); // remove o campo Senha de Colaborador do Model State
            if (ModelState.IsValid)
            {
                _colaboradorrepository.Atualizar(colaborador);

                TempData["Mens_S"] = Mensagem.MSG_S001;

                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        [ValidateHttpReferer]
        public IActionResult Excluir(int id)
        {
            _colaboradorrepository.Excluir(id);

            TempData["Mens_S"] = Mensagem.MSG_S002;

            return RedirectToAction(nameof(Index));
        }
    }
}
