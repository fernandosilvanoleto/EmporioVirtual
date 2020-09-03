using Microsoft.AspNetCore.Http;
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
        private IHttpContextAccessor _context;
        public Cookie(IHttpContextAccessor context)
        {
            _context = context;
        }
        public void Cadastrar(string Key, string Valor)
        {
            CookieOptions Options = new CookieOptions();
            Options.Expires = DateTime.Now.AddDays(10);
            Options.IsEssential = true; // PARA FUNCIONAR PARA QUALQUER NAVEGADOR!!!

            _context.HttpContext.Response.Cookies.Append(Key, Valor, Options);
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

        public string Consultar(string Key)
        {
            // verificar se o cookie existe
            return _context.HttpContext.Request.Cookies[Key];
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
