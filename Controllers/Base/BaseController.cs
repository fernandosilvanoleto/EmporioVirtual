using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EmporioVirtual.Libraries.CarrinhoCompra;
using EmporioVirtual.Libraries.Gerenciador.Frete;
using EmporioVirtual.Models.ProdutoAgregador;
using EmporioVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace EmporioVirtual.Controllers.Base
{
    public class BaseController : Controller
    {
        protected CookieCarrinhoCompra _cookiecarrinhocompra;
        protected IProdutoRepository _produtorepository;
        protected IMapper _mapper;
        protected WSCorreiosCalcularFrete _wsorreiosCalcularFrete;
        protected CalcularPacote _calcularpacote;
        protected CookieValorPrazoFrete _cookieValorPrazoFrete;

        public BaseController(CookieCarrinhoCompra carrinhocompra, IProdutoRepository produtorepository, IMapper mapper, WSCorreiosCalcularFrete wsorreiosCalcularFrete, CalcularPacote calcularpacote, CookieValorPrazoFrete cookieValorPrazoFrete)
        {
            _cookiecarrinhocompra = carrinhocompra;
            _produtorepository = produtorepository;
            _mapper = mapper;
            _wsorreiosCalcularFrete = wsorreiosCalcularFrete;
            _calcularpacote = calcularpacote;
            _cookieValorPrazoFrete = cookieValorPrazoFrete;
        }

        protected List<ProdutoItem> CarregarProdutoBancoDados()
        {
            List<ProdutoItem> produtoItemCarrinho = _cookiecarrinhocompra.Consultar();

            List<ProdutoItem> ProdutoItemCompleto = new List<ProdutoItem>();

            foreach (var item in produtoItemCarrinho)
            {
                // AUTOMAPPER- COPIAR UM OBJETO PARA OUTRO OBJETO
                Produto produto = _produtorepository.ObterProduto(item.Id);



                // CRIAR UM PRODUTO ITEM DINAMICAMENTE - COM USO DE AUTO MAPPER
                ProdutoItem produtoItem = _mapper.Map<ProdutoItem>(produto);

                // ADICIONA A ÚNICA PROPRIEDADE QUE NÃO PERTENCE AO PRODUTO
                produtoItem.QuantidadeProdutoCarrinho = item.QuantidadeProdutoCarrinho;

                ProdutoItemCompleto.Add(produtoItem);

            }

            return ProdutoItemCompleto;
        }
    }
}
