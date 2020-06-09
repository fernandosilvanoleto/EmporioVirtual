using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmporioVirtual.Libraries.Login;
using EmporioVirtual.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EmporioVirtual.Libraries.Filtro
{
    /*
     * Tipo de Filtros
     * - Autorização
     * - Recurso
     * - Ação
     * Exceção
     * Resultado
     * 
     */
    public class ClienteAutorizacaoAttribute : Attribute, IAuthorizationFilter
    {
        LoginCliente _loginCliente;
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // em vez de injetar service via método, faz isso aqui que dar certo
            // precisou colocar o cast para retornar objeto do tipo LoginCliente
            _loginCliente = (LoginCliente)context.HttpContext.RequestServices.GetService(typeof(LoginCliente));
            
            Cliente clienteDB = _loginCliente.GetCliente();
            
            if (clienteDB == null)
            {
                context.Result = new ContentResult() { Content = "Acesso negado." };
            }
        }
    }
}
