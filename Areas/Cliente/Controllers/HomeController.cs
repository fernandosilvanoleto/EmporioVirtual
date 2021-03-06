﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmporioVirtual.Libraries.Login;
using EmporioVirtual.Repositories.Contracts;
using EmporioVirtual.Libraries.Email;
using EmporioVirtual.Libraries.Filtro;
using EmporioVirtual.Models.Constants;
using EmporioVirtual.Libraries.Texto;
using EmporioVirtual.Models;
using System.Diagnostics;

namespace EmporioVirtual.Areas.Cliente.Controllers
{
    [Area("Cliente")]
    public class HomeController : Controller
    {
        private IClienteRepository _repositoryCliente;
        private IEnderecoEntregaRepository _enderecoEntrega;
        private LoginCliente _loginCliente;
        private GerenciarEmail _gerenciaremail;

        //INJEÇÃO DE DEPENDÊNCIA
        public HomeController(IClienteRepository repositorycliente, IEnderecoEntregaRepository enderecoEntrega, LoginCliente loginCliente, GerenciarEmail gerenciaremail)
        {
            _repositoryCliente = repositorycliente;
            _enderecoEntrega = enderecoEntrega;
            _loginCliente = loginCliente;
            _gerenciaremail = gerenciaremail;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm] Models.Cliente cliente, string returnUrl = null)
        {
            Models.Cliente clienteDB = _repositoryCliente.Login(cliente.Email, cliente.Senha);

            if (clienteDB != null)
            {
                _loginCliente.Login(clienteDB);

                if (returnUrl == null)
                {
                    // com url action se tiver alteração de nome no método, aqui altera tbém
                    return new RedirectResult(Url.Action(nameof(Painel)));
                }
                else
                {
                    // CRIADO NO DIA 02/11/2020
                    // SERVE PARA DIRECIONAR USUÁRIO QUE ESTÁ LOGANDO COM PRODUTO CARREGADO EM CARRINHOS COMPRAS
                    return LocalRedirectPermanent(returnUrl);
                }

               
            }
            else
            {
                ViewData["Msg_Error"] = "Usuário ou Senha incorretos! Por favor, coloque as informações corretas!!!";
                return View();
            }
        }

        [HttpGet]
        [ClienteAutorizacaoAttribute]
        public IActionResult Painel()
        {
            return new ContentResult() { Content = "Este é o painel do Cliente!!!" };
        }

        [HttpGet]
        public IActionResult CadastroCliente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroCliente([FromForm] Models.Cliente cliente, string returnUrl = null)
        {
            ModelState.Remove("Senha");
            ModelState.Remove("ConfirmarSenha");
            if (ModelState.IsValid)
            {
                cliente.Situacao = SituacaoConstant.Ativo;

                cliente.Senha = KeyGenerator.GetUnique(8);

                _repositoryCliente.Cadastrar(cliente);

                _loginCliente.Login(cliente);

                TempData["Mensagem_S"] = "Cadastro realizado com sucesso";

                if (returnUrl == null)
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
                else
                {
                    return LocalRedirectPermanent(returnUrl);
                }           

            }
            return View();
        }

        [HttpGet]
        public IActionResult CadastroEnderecoEntrega()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult CadastroEnderecoEntrega([FromForm] EnderecoEntrega enderecoEntrega, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                enderecoEntrega.ClienteId = _loginCliente.GetCliente().Id;

                _enderecoEntrega.Cadastrar(enderecoEntrega);

                if (returnUrl == null)
                {
                    // LISTAGEM DE ENDEREÇOS
                }
                else
                {
                    return LocalRedirectPermanent(returnUrl);
                }
            }
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
