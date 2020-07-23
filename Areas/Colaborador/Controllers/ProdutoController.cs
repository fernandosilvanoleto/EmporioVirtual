using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmporioVirtual.Libraries.Arquivo;
using EmporioVirtual.Libraries.Lang;
using EmporioVirtual.Models;
using EmporioVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmporioVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    public class ProdutoController : Controller
    {
        private IProdutoRepository _produtorepository;
        private ICategoriaRepository _categoriaRepository;
        private IImagemRepository _imagemRepository;
        public ProdutoController(IProdutoRepository produtorepository, ICategoriaRepository categoriaRepository, IImagemRepository imagemRepository)
        {
            _produtorepository = produtorepository;
            _categoriaRepository = categoriaRepository;
            _imagemRepository = imagemRepository;
        }

        public IActionResult Index(int? pagina, string pesquisa)
        {
            var produtos = _produtorepository.ObterTodosProdutos(pagina, pesquisa);
            return View(produtos);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            ViewBag.Categorias = _categoriaRepository.ObterTodasCategoriasSelect().Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                //salvar produto
                _produtorepository.Cadastrar(produto);
                
                List<Imagem> ListaImagensDefinitiva = GerenciadorArquivo.MoverImagensProduto(new List<string>(Request.Form["imagem"]), produto.Id);
                //CaminhoTemp -> Mover a Imagem para caminho definitivo
                // Salvar o caminho definitivo e salvar no banco de dados

                _imagemRepository.CadastrarImagens(ListaImagensDefinitiva, produto.Id);

                TempData["Mens_S"] = Mensagem.MSG_S001;

                return RedirectToAction(nameof(Index));
            }
            else
            {                
               produto.Imagens = new List<string>(Request.Form["imagem"]).Where(a=>a.Trim().Length > 0).Select(a=>new Imagem() { Caminho = a  }).ToList();
               ViewBag.Categorias = _categoriaRepository.ObterTodasCategoriasSelect().Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
               return View(produto);
            }            
        }

        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            Produto produto = _produtorepository.ObterProduto(id);
            
            ViewBag.Categorias = _categoriaRepository.ObterTodasCategoriasSelect().Select(a => new SelectListItem(a.Nome, a.Id.ToString()));

            return View(produto);
        }

        [HttpPost]
        public IActionResult Atualizar(Produto produto, int id)
        {
            if (ModelState.IsValid)
            {
                //salvar produto
                _produtorepository.Atualizar(produto);                

                List<Imagem> ListaImagensDefinitiva = GerenciadorArquivo.MoverImagensProduto(new List<string>(Request.Form["imagem"]), produto.Id);
                //CaminhoTemp -> Mover a Imagem para caminho definitivo
                // Salvar o caminho definitivo e salvar no banco de dados

                _imagemRepository.ExcluirImagensdoProduto(produto.Id);

                _imagemRepository.CadastrarImagens(ListaImagensDefinitiva, produto.Id);

                TempData["Mens_S"] = Mensagem.MSG_S001;

                return RedirectToAction(nameof(Index));
            }
            else
            {
                produto.Imagens = new List<string>(Request.Form["imagem"]).Where(a => a.Trim().Length > 0).Select(a => new Imagem() { Caminho = a }).ToList();
                ViewBag.Categorias = _categoriaRepository.ObterTodasCategoriasSelect().Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
                return View(produto);
            }
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            // LER O PRODUTO
            Produto Produto = _produtorepository.ObterProduto(id);

            // DELETAR IMAGENS DA PASTA
            GerenciadorArquivo.ExcluirImagensDeProduto(Produto.Imagens.ToList());

            //DELETAR IMAGENS DO BANCO
            _imagemRepository.ExcluirImagensdoProduto(id);

            //DELETAR PRODUTO
            _produtorepository.Excluir(id);

            TempData["Mens_S"] = Mensagem.MSG_S002;

            return RedirectToAction(nameof(Index));
        }
    }
}
