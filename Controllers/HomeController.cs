using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EmporioVirtual.Models;
using EmporioVirtual.Libraries.Email;
using System.Text;

namespace EmporioVirtual.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromForm]NewsletterEmail newsletter)
        {
            //ADIÇÃO NO BANCO DE DADOS

            NewsletterEmail email = new NewsletterEmail();
            email = newsletter;
            //VALIDAÇÕES
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
                    ContatoEmail.EnviarContatoPorEmail(contato);

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

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult CadastroCliente()
        {
            return View();
        }

        public IActionResult CarrinhoCompra()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
