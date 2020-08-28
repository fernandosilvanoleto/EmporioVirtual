using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmporioVirtual.Libraries.CarrinhoCompra;
using EmporioVirtual.Models;
using EmporioVirtual.Models.ProdutoAgregador;
using EmporioVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace EmporioVirtual.Controllers
{
    public class CarrinhoController : Controller
    {
        private CarrinhoCompra _carrinhocompra;
        private IProdutoRepository _produtorepository;

        public CarrinhoController(CarrinhoCompra carrinhocompra, IProdutoRepository produtorepository)
        {
            _carrinhocompra = carrinhocompra;
            _produtorepository = produtorepository;
        }
        public IActionResult Index()
        {
            List<ProdutoItem> produtoItemCarrinho = _carrinhocompra.Consultar();

            List<ProdutoItem> ProdutoItemCompleto = new List<ProdutoItem>();

            foreach (var item in produtoItemCarrinho)
            {
                // TODO - AUTOMAPPER
                Produto produto = _produtorepository.ObterProduto(item.Id);

                // CRIAR UM PRODUTO ITEM DINAMICAMENTE
                ProdutoItem produtoItem = new ProdutoItem();

                produtoItem.Id = produto.Id;
                produtoItem.Nome = produto.Nome;
                produtoItem.Imagens = produto.Imagens;
                produtoItem.Valor = produto.Valor;
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
                // TODO - caso produto já exista, deve ser adicionado uma quantidade maior
                var item = new ProdutoItem() { Id = id, QuantidadeProdutoCarrinho = 1 };

                // ADICIONAR ITEM NO CARRINHO
                _carrinhocompra.Cadastrar(item);

                return RedirectToAction(nameof(Index));
            }
        }

        public IActionResult AlterarQuantidade(int id, int quantidade)
        {
            var Item = new ProdutoItem() { Id = id, QuantidadeProdutoCarrinho = quantidade };
            _carrinhocompra.Atualizar(Item);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult RemoverItem(int id)
        {
            _carrinhocompra.Remover(new ProdutoItem() { Id = id});
            return RedirectToAction(nameof(Index));
        }
    }
}
