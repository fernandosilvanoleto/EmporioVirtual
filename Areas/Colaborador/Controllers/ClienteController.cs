using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmporioVirtual.Models;
using EmporioVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace EmporioVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    public class ClienteController : Controller
    {
        private IClienteRepository _clienterepository;
        public ClienteController(IClienteRepository clienterepository)
        {
            _clienterepository = clienterepository;
        }
        public IActionResult Index(int pagina)
        {
            IPagedList<Cliente> clientes = _clienterepository.ObterTodosClientes(pagina);
            return View();
        }

        public IActionResult AtivarDesativar()
        {
            return View();
        }
    }
}
