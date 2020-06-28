using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmporioVirtual.Libraries.Filtro;
using EmporioVirtual.Libraries.Lang;
using EmporioVirtual.Models;
using EmporioVirtual.Models.Constants;
using EmporioVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace EmporioVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    [ColaboradorAutorizacao]
    public class ClienteController : Controller
    {
        private IClienteRepository _clienterepository;
        public ClienteController(IClienteRepository clienterepository)
        {
            _clienterepository = clienterepository;
        }
        public IActionResult Index(int? pagina)
        {
            IPagedList<Cliente> clientes = _clienterepository.ObterTodosClientes(pagina);
            return View(clientes);
        }

        [ValidateHttpReferer]
        public IActionResult AtivarDesativar(int id)
        {
            Cliente cliente = _clienterepository.ObterCliente(id);

            if (cliente.Situacao == SituacaoConstant.Ativo)
            {
                cliente.Situacao = SituacaoConstant.Desativado;
            } else
            {
                cliente.Situacao = SituacaoConstant.Ativo;
            }

            _clienterepository.Atualizar(cliente);

            TempData["Mens_S"] = Mensagem.MSG_S001;

            return RedirectToAction(nameof(Index));
        }
    }
}
