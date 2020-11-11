﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmporioVirtual.Libraries.CarrinhoCompra;
using EmporioVirtual.Models;
using EmporioVirtual.Models.ProdutoAgregador;
using EmporioVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using EmporioVirtual.Libraries.Lang;
using EmporioVirtual.Models.Constants;
using EmporioVirtual.Libraries.Gerenciador.Frete;
using EmporioVirtual.Controllers.Base;

namespace EmporioVirtual.Controllers
{
    //NOVIDADE ==> HERDAR DE BASE CONTROLLER => 20/10/2020
    public class CarrinhoController : BaseController
    {

        // UM CONSTRUTOR SIMPLES
        public CarrinhoController(CookieCarrinhoCompra carrinhocompra, IProdutoRepository produtorepository, IMapper mapper, WSCorreiosCalcularFrete wsorreiosCalcularFrete, CalcularPacote calcularpacote, CookieValorPrazoFrete cookieValorPrazoFrete) : base(carrinhocompra, produtorepository, mapper, wsorreiosCalcularFrete, calcularpacote, cookieValorPrazoFrete)
        {

        }
        public IActionResult Index()
        {
            List<ProdutoItem> ProdutoItemCompleto = CarregarProdutoBancoDados();

            return View(ProdutoItemCompleto);
        }
        

        //Item Id = Id Produto
        public IActionResult AdicionarItem(int id)
        {
            Produto produto = _produtorepository.ObterProduto(id);

            if (produto == null)
            {
                // produto não existe no banco, apresentar mensagem de erros
                return View("ItemNaoExiste");
            }
            else
            {
                // caso produto já exista, deve ser adicionado uma quantidade maior
                var item = new ProdutoItem() { Id = id, QuantidadeProdutoCarrinho = 1 };

                // ADICIONAR ITEM NO CARRINHO
                _cookiecarrinhocompra.Cadastrar(item);

                return RedirectToAction(nameof(Index));
            }
        }

        public IActionResult AlterarQuantidade(int id, int quantidade)
        {
            // VALIDAR SE EXISTE A QUANTIDADE NO ESTOQUE
            Produto produto = _produtorepository.ObterProduto(id);
            if (quantidade < 1)
            {
                return BadRequest(new { mensagem = Mensagem.MSG_E007 });
            }
            else if (quantidade > produto.Quantidade)
            {
                return BadRequest(new { mensagem = Mensagem.MSG_E008 });
            }
            else
            {
                var Item = new ProdutoItem() { Id = id, QuantidadeProdutoCarrinho = quantidade };
                _cookiecarrinhocompra.Atualizar(Item);

                return Ok(new { mensagem = Mensagem.MSG_S001 });
            }            
        }

        public IActionResult RemoverItem(int id)
        {
            _cookiecarrinhocompra.Remover(new ProdutoItem() { Id = id});
            return RedirectToAction(nameof(Index));
        }

        public IActionResult EnderecoEntrega()
        {
            return View();
        }        


        public async Task<IActionResult> CalcularFrete(int cepDestino)
        {
            try
            {
                List<ProdutoItem> produtos = CarregarProdutoBancoDados();
                //TipoFreteConstant
                List<Pacote> pacotes = _calcularpacote.CalcularPacotesDeProduto(produtos);

                ValorPrazoFrete valorPAC = await _wsorreiosCalcularFrete.CalcularFrete(cepDestino.ToString(), TipoFreteConstant.PAC, pacotes);
                ValorPrazoFrete valorSEDEX = await _wsorreiosCalcularFrete.CalcularFrete(cepDestino.ToString(), TipoFreteConstant.SEDEX, pacotes);
                ValorPrazoFrete valorSEDEX10 = await _wsorreiosCalcularFrete.CalcularFrete(cepDestino.ToString(), TipoFreteConstant.SEDEX10, pacotes);

                List<ValorPrazoFrete> lista = new List<ValorPrazoFrete>();
                if(valorPAC != null) lista.Add(valorPAC);
                if (valorSEDEX != null) lista.Add(valorSEDEX);
                if (valorSEDEX10 != null) lista.Add(valorSEDEX10);

                _cookieValorPrazoFrete.Cadastrar(lista);

                return Ok(lista);
            }
            catch (Exception e)
            {
                _cookieValorPrazoFrete.Remover();
                return BadRequest(e);
            }            
        }



        /*
         * DESATIVADA :: 20/10/2020
         * 
         * private List<ProdutoItem> CarregarProdutoBancoDados()
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
        }*/
    }
}
