using EmporioVirtual.Libraries.Login;
using EmporioVirtual.Models;
using EmporioVirtual.Models.Constants;
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
        private string _tipocolaboradornecessario;
        public ColaboradorAutorizacaoAttribute(string TipoColaboradorNecessario = ColaboradorTipoConstant.Comum)
        {
            _tipocolaboradornecessario = TipoColaboradorNecessario;
        }

        LoginColaborador _loginColaborador;
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // em vez de injetar service via método, faz isso aqui que dar certo
            // precisou colocar o cast para retornar objeto do tipo LoginCliente
            _loginColaborador = (LoginColaborador)context.HttpContext.RequestServices.GetService(typeof(LoginColaborador));

            Colaborador colaboradorDB = _loginColaborador.GetColaborador();

            if (colaboradorDB == null)
            {
                context.Result = new RedirectToActionResult("Login", "Home", null);
            } 
            else
            {
                if (colaboradorDB.Tipo == ColaboradorTipoConstant.Comum && _tipocolaboradornecessario == ColaboradorTipoConstant.Gerente)
                {
                    context.Result = new ForbidResult();
                }
            }
        }  
    }
}
