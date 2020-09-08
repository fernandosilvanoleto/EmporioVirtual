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

namespace EmporioVirtual.Controllers
{
    public class CarrinhoController : Controller
    {
        private CarrinhoCompra _carrinhocompra;
        private IProdutoRepository _produtorepository;
        private IMapper _mapper;

        public CarrinhoController(CarrinhoCompra carrinhocompra, IProdutoRepository produtorepository, IMapper mapper)
        {
            _carrinhocompra = carrinhocompra;
            _produtorepository = produtorepository;
            _mapper = mapper;
        }
        public IActionResult Index()
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
            var Item = new ProdutoItem() { Id = id, QuantidadeProdutoCarrinho = quantidade };
            _carrinhocompra.Atualizar(Item);

            return Ok();//RedirectToAction(nameof(Index));
        }

        public IActionResult RemoverItem(int id)
        {
            _carrinhocompra.Remover(new ProdutoItem() { Id = id});
            return RedirectToAction(nameof(Index));
        }
    }
}
