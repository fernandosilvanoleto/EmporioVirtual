using EmporioVirtual.Libraries.Seguranca;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Libraries.Cookie
{
    public class Cookie
    {
        // COOKIE SERÁ USADO PARA O CARRINHO DE COMPRA
        // injenção de dependência
        // ENTRA NO STARTUP.CS E ADICIONA O ADD SCOPED COM O NOME COOKIE
        // services.AddScoped<EmporioVirtual.Libraries.Cookie.Cookie>();
        // ADOTAR A CRIPTOGRAFIA QUE CRIEI - 16/09/2020
        private IHttpContextAccessor _context;
        private IConfiguration _configuration;

        // IConfiguration - USA DA MICROSOFT
        public Cookie(IHttpContextAccessor context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public void Cadastrar(string Key, string Valor)
        {
            CookieOptions Options = new CookieOptions();
            Options.Expires = DateTime.Now.AddDays(10);
            Options.IsEssential = true; // PARA FUNCIONAR PARA QUALQUER NAVEGADOR!!!

            // LIBRARIES -> Segurança
            // "KeyCrypt" vem de appsettings.json/appsettings.Development.json => onde contém a chave utilizada para criptografar 
            var ValorCrypt = StringCipher.Encrypt(Valor, _configuration.GetValue<string>("KeyCrypt"));

            _context.HttpContext.Response.Cookies.Append(Key, ValorCrypt, Options);
        }

        public void Atualizar(string Key, string Valor)
        {
            if (Existe(Key))
            {
                Remover(Key);
            }
            Cadastrar(Key, Valor);
        }

        public void Remover(string Key)
        {
            _context.HttpContext.Response.Cookies.Delete(Key);
        }


        // NOVA FUNCIONALIDADE :: 22/10/2020 -> SERVIR PARA PagamentoController
        // bool Cript = true -> NÃO IMPACTAR OUTRAS FUNCIONALIDADES => É CHAMADO DE VALOR PADRÃO
        public string Consultar(string Key, bool Cript = true)
        {
            // verificar se o cookie existe
            var valor = _context.HttpContext.Request.Cookies[Key];
            if (Cript)
            {
                valor = StringCipher.Decrypt(valor, _configuration.GetValue<string>("KeyCrypt"));
            }

            return valor;
            //return _context.HttpContext.Request.Cookies[Key];
        }

        public bool Existe(string Key)
        {
            if (_context.HttpContext.Request.Cookies[Key] == null)
            {
                return false;
            }
            return true;
        }

        public void RemoverTodos()
        {
            var ListaCookie = _context.HttpContext.Request.Cookies.ToList();
            foreach (var cookie in ListaCookie)
            {
                Remover(cookie.Key);
            }            
        }
    }
}
