using EmporioVirtual.Models.ProdutoAgregador;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Libraries.CarrinhoCompra
{
    public class CarrinhoCompra
    {
        private string Key = "Carrinho.Compras";
        private Cookie.Cookie _cookie;
        public CarrinhoCompra(Cookie.Cookie cookie)
        {
            _cookie = cookie;
        }

        // CRUD

        public void Cadastrar(ProdutoItem item)
        {
            List<ProdutoItem> Lista;
            if (_cookie.Existe(Key))
            {
                // LER E ADICIONAR ITENS NO CARRINHO EXISTENTE
                Lista = Consultar();
                var ItemLocalizado = Lista.SingleOrDefault(a => a.Id == item.Id);
               
                if (ItemLocalizado == null)
                {
                    Lista.Add(item);
                }
                else
                {
                    ItemLocalizado.QuantidadeProdutoCarrinho = ItemLocalizado.QuantidadeProdutoCarrinho + 1;
                } 
            }
            else
            {
                // CRIAR O COOKIE COM O ITEM DO CARRINHO
                Lista = new List<ProdutoItem>();
                Lista.Add(item);

                // SALVAR UM NOVO ITEM
            }
            // SALVAR DADOS
            Salvar(Lista);
        }

        public void Atualizar(ProdutoItem item)
        {
            var Lista = Consultar();
            var ItemLocalizado = Lista.SingleOrDefault(a => a.Id == item.Id);

            if (ItemLocalizado != null)
            {
                ItemLocalizado.QuantidadeProdutoCarrinho = item.QuantidadeProdutoCarrinho;
                // SALVAR ESSA LISTA
                Salvar(Lista);
            }

        }

        public void Remover(ProdutoItem item)
        {
            var Lista = Consultar();
            var ItemLocalizado = Lista.SingleOrDefault(a => a.Id == item.Id);

            if (ItemLocalizado != null)
            {
                Lista.Remove(ItemLocalizado);
                // SALVAR ESSA LISTA
                Salvar(Lista);
            }
        }

        public List<ProdutoItem> Consultar()
        {
            // verificar se o cookie existe
            if (_cookie.Existe(Key))
            {
                string valor = _cookie.Consultar(Key);

                return JsonConvert.DeserializeObject<List<ProdutoItem>>(valor);
            }
            else
            {
                return new List<ProdutoItem>();
            }
               
         }

        public void Salvar(List<ProdutoItem> Lista)
        {
            // SALVAR COOKIE NO NAVEGADOR
            string Valor = JsonConvert.SerializeObject(Lista);
            _cookie.Cadastrar(Key, Valor);
        }

        public bool Existe(string Key)
        {
            if (_cookie.Existe(Key))
            {
                return false;
            }
            return true;
        }

        public void RemoverTodos()
        {
            // REMOVER SÓ O CARRO, EM VEZ DE TUDO
            _cookie.Remover(Key);
        }


    }
}
