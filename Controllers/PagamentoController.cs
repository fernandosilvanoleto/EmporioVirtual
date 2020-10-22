using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EmporioVirtual.Controllers.Base;
using EmporioVirtual.Libraries.CarrinhoCompra;
using EmporioVirtual.Libraries.Cookie;
using EmporioVirtual.Libraries.Gerenciador.Frete;
using EmporioVirtual.Libraries.Lang;
using EmporioVirtual.Models.ProdutoAgregador;
using EmporioVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace EmporioVirtual.Controllers
{
    public class PagamentoController : BaseController
    {
        private Cookie _cookie;
        public PagamentoController(CookieCarrinhoCompra carrinhocompra, IProdutoRepository produtorepository, IMapper mapper, WSCorreiosCalcularFrete wsorreiosCalcularFrete, CalcularPacote calcularpacote, CookieValorPrazoFrete cookieValorPrazoFrete, Cookie cookie) : base(carrinhocompra, produtorepository, mapper, wsorreiosCalcularFrete, calcularpacote, cookieValorPrazoFrete)
        {
            _cookie = cookie;
        }
        public IActionResult Index()
        {
            // Cookie => INFORMAÇÕES DO FRETE CORREIOS

            // USAR CLASSE COOKIE DA LIB
            // QUAL USUÁRIO SELECIONOU
            var TipoFreteSelecionadoPeloUsuario = _cookie.Consultar("Carrinho.TipoFrete", false);

            // 
            var Frete = _cookieValorPrazoFrete.Consultar().Where(a => a.TipoFrete == TipoFreteSelecionadoPeloUsuario).FirstOrDefault();

            if (Frete != null)
            {

            }
            else
            {
                TempData["MSG_E"] = Mensagem.MSG_E009;
                return RedirectToAction("Index", "Carrinho");
            }

            // BUSCAR PRODUTOS DO COOKIE ESCOLHIDOS
            List<ProdutoItem> produtoItemProduto = CarregarProdutoBancoDados();

            // CARREGAR O PRODUTO NA TELA :: INDEX
            return View(produtoItemProduto);
        }
    }
}
