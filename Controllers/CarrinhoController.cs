using System;
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

namespace EmporioVirtual.Controllers
{
    public class CarrinhoController : Controller
    {
        private CarrinhoCompra _carrinhocompra;
        private IProdutoRepository _produtorepository;
        private IMapper _mapper;
        private WSCorreiosCalcularFrete _wsorreiosCalcularFrete;
        private CalcularPacote _calcularpacote;

        public CarrinhoController(CarrinhoCompra carrinhocompra, IProdutoRepository produtorepository, IMapper mapper, WSCorreiosCalcularFrete wsorreiosCalcularFrete, CalcularPacote calcularpacote)
        {
            _carrinhocompra = carrinhocompra;
            _produtorepository = produtorepository;
            _mapper = mapper;
            _wsorreiosCalcularFrete = wsorreiosCalcularFrete;
            _calcularpacote = calcularpacote;
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
                _carrinhocompra.Cadastrar(item);

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
                _carrinhocompra.Atualizar(Item);

                return Ok(new { mensagem = Mensagem.MSG_S001 });
            }            
        }

        public IActionResult RemoverItem(int id)
        {
            _carrinhocompra.Remover(new ProdutoItem() { Id = id});
            return RedirectToAction(nameof(Index));
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
                lista.Add(valorPAC);
                lista.Add(valorSEDEX);
                lista.Add(valorSEDEX10);

                return Ok(lista);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }            
        }



        private List<ProdutoItem> CarregarProdutoBancoDados()
        {
            List<ProdutoItem> produtoItemCarrinho = _carrinhocompra.Consultar();

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
