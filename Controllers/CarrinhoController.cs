using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmporioVirtual.Libraries.CarrinhoCompra;
using EmporioVirtual.Models;
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
            return View();
        }

        //Item Id = Id Produto
        public IActionResult AdicionarItem(int id)
        {
            Produto produto = _produtorepository.ObterProduto(id);

            if (produto == null)
            {
                // produto não existe no banco, apresentar mensagem de erros
                return View();
            }
            else
            {
                var item = new Item() { Id = id, Quantidade = 1 };

                // ADICIONAR ITEM NO CARRINHO
                _carrinhocompra.Cadastrar(item);

                return RedirectToAction(nameof(Index));
            }

           
            return View();
        }

        public IActionResult AlterarQuantidade()
        {
            return View();
        }

        public IActionResult RemoverItem()
        {
            return View();
        }
    }
}
