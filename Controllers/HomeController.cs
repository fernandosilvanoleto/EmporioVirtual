using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using EmporioVirtual.Database;
using EmporioVirtual.Models;
using EmporioVirtual.Repositories.Contracts;
using EmporioVirtual.Libraries.Login;
using EmporioVirtual.Libraries.Filtro;
using EmporioVirtual.Libraries.Email;
using EmporioVirtual.Models.Constants;
using EmporioVirtual.Libraries.Texto;
using EmporioVirtual.Models.ViewModels;

namespace EmporioVirtual.Controllers
{
    public class HomeController : Controller
    {
        private IClienteRepository _repositoryCliente;
        private INewsLetterRepository _repositoryNewsLetter;
        private IProdutoRepository _produtorepository;
        private LoginCliente _loginCliente;
        private GerenciarEmail _gerenciaremail;

        //INJEÇÃO DE DEPENDÊNCIA
        public HomeController(IClienteRepository repositorycliente, INewsLetterRepository repositorynewsletter, LoginCliente loginCliente, GerenciarEmail gerenciaremail, IProdutoRepository produtorepository)
        {
            _repositoryCliente = repositorycliente;
            _repositoryNewsLetter = repositorynewsletter;
            _loginCliente = loginCliente;
            _gerenciaremail = gerenciaremail;
            _produtorepository = produtorepository;
        }

        /*public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromForm]NewsletterEmail newsletter)
        {
            //VALIDANDO FORMULÁRIO VINDO DA VIEW
            if (ModelState.IsValid)
            {
                _repositoryNewsLetter.Cadastrar(newsletter);

                TempData["Mensagem_S"] = "Obrigado pelo cadastro e-mail! Vamos enviar promoções especiais ao seu email!";

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }            
        }

        public IActionResult Categoria()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContatoAcao()
        {
            try
            {
                Contato contato = new Contato();
                contato.Nome = HttpContext.Request.Form["nome"];
                contato.Email = HttpContext.Request.Form["email"];
                contato.Texto = HttpContext.Request.Form["texto"];

                var listamensagens = new List<ValidationResult>();
                var contexto = new ValidationContext(contato);
                bool isValid = Validator.TryValidateObject(contato, contexto, listamensagens, true);

                if (isValid)
                {
                    _gerenciaremail.EnviarContatoPorEmail(contato);

                    ViewData["Msg_S"] = "Mensagem de contato enviado com sucesso";
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var item in listamensagens)
                    {
                        sb.Append(item.ErrorMessage + "<br />");
                    }
                    ViewData["Msg_Error"] = sb.ToString();
                    ViewData["Contato"] = contato;
                }

            }
            catch (Exception e)
            {
                ViewData["Msg_Error"] = "Ops! Tivemos um erro, tente novamente mais tarde!!!" + e.Message;
                
                // TODO - Implementar log
            }

            return View(nameof(Contato));
        }        
    }
}
