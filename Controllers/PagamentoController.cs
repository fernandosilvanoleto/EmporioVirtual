using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EmporioVirtual.Controllers.Base;
using EmporioVirtual.Libraries.CarrinhoCompra;
using EmporioVirtual.Libraries.Gerenciador.Frete;
using EmporioVirtual.Models.ProdutoAgregador;
using EmporioVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace EmporioVirtual.Controllers
{
    public class PagamentoController : BaseController
    {
        public PagamentoController(CookieCarrinhoCompra carrinhocompra, IProdutoRepository produtorepository, IMapper mapper, WSCorreiosCalcularFrete wsorreiosCalcularFrete, CalcularPacote calcularpacote, CookieValorPrazoFrete cookieValorPrazoFrete) : base(carrinhocompra, produtorepository, mapper, wsorreiosCalcularFrete, calcularpacote, cookieValorPrazoFrete)
        {

        }
        public IActionResult Index()
        {
            // BUSCAR PRODUTOS DO COOKIE ESCOLHIDOS
            List<ProdutoItem> produtoItemProduto = CarregarProdutoBancoDados();

            // CARREGAR O PRODUTO NA TELA :: INDEX
            return View(produtoItemProduto);
        }
    }
}
