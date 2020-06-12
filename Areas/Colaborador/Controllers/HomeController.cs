using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmporioVirtual.Libraries.Filtro;
using EmporioVirtual.Libraries.Login;
using EmporioVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace EmporioVirtual.Areas.Colaborador.Controllers
{
    //ISSO FAZ FUNCIONA ESSA AREA COM ESSA CONTROLLER
    [Area("Colaborador")]
    public class HomeController : Controller
    {
        private IColaboradorRepository _repositoryColaborador;
        private LoginColaborador _loginColaborador;
        public HomeController(IColaboradorRepository repositoryColaborador, LoginColaborador loginColaborador)
        {
            _repositoryColaborador = repositoryColaborador;
            _loginColaborador = loginColaborador;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm]Models.Colaborador colaborador)
        {
            //USA ISSO PQ O MODEL ESTÁ LOCALIZADO EM OUTRO LOCAL
            Models.Colaborador colaboradorDB = _repositoryColaborador.Login(colaborador.Email, colaborador.Senha);

            if (colaboradorDB != null)
            {
                _loginColaborador.Login(colaboradorDB);

                // com url action se tiver alteração de nome no método, aqui altera tbém
                return new RedirectResult(Url.Action(nameof(Painel)));
            }
            else
            {
                ViewData["Msg_Error"] = "Usuário ou Senha incorretos! Por favor, coloque as informações corretas!!!";
                return View();
            }
        }

        [ColaboradorAutorizacao]
        public IActionResult Logout()
        {
            _loginColaborador.Logout();
            return RedirectToAction("Login", "Home");
        }

        [ColaboradorAutorizacao]
        public IActionResult Painel()
        {
            return View();
        }
        public IActionResult RecuperarSenha()
        {
            return View();
        }
        public IActionResult CadastrarNovaSenha()
        {
            return View();
        }
    }
}
