using EmporioVirtual.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Libraries.CarrinhoCompra
{
    public class CookieValorPrazoFrete
    {
        private string Key = "Carrinho.ValorPrazoFrete";
        private Cookie.Cookie _cookie;
        public CookieValorPrazoFrete(Cookie.Cookie cookie)
        {
            _cookie = cookie;
        }

        public void Cadastrar(List<ValorPrazoFrete> lista)
        {
            string Valor = JsonConvert.SerializeObject(lista);
            _cookie.Cadastrar(Key, Valor);
        }

        public List<ValorPrazoFrete> Consultar()
        {
            // verificar se o cookie existe
            if (_cookie.Existe(Key))
            {
                string valor = _cookie.Consultar(Key);

                return JsonConvert.DeserializeObject<List<ValorPrazoFrete>>(valor);
            }
            else
            {
                // ANALISAR MELHOR
                return null;
            }
        }

        public void Remover()
        {
            // REMOVER SÓ O CARRO, EM VEZ DE TUDO
            _cookie.Remover(Key);
        }
    }

}
