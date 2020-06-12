using EmporioVirtual.Libraries.Login;
using EmporioVirtual.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Libraries.Filtro
{
    public class ColaboradorAutorizacaoAttribute : Attribute, IAuthorizationFilter
    {
        LoginColaborador _loginColaborador;
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // em vez de injetar service via método, faz isso aqui que dar certo
            // precisou colocar o cast para retornar objeto do tipo LoginCliente
            _loginColaborador = (LoginColaborador)context.HttpContext.RequestServices.GetService(typeof(LoginColaborador));

            Colaborador clienteDB = _loginColaborador.GetColaborador();

            if (clienteDB == null)
            {
                context.Result = new ContentResult() { Content = "Acesso negado." };
            }
        }  
    }
}
