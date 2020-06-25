using EmporioVirtual.Models;
using EmporioVirtual.Repositories.Contracts;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Libraries.Validacao
{
    public class EmailUnicoColaboradorAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationcontext)
        {
            //TODO: obter email
            string Email = value as string;

            //Obter o Repository do Colaborador
            IColaboradorRepository _colaboradorrepository = (IColaboradorRepository)validationcontext.GetService(typeof(IColaboradorRepository));

            //Fazer Verificação de email único na tabela
            List<Colaborador> colaboradores = _colaboradorrepository.ObterColaboradorPorEmail(Email);

            return base.IsValid(value, validationcontext);
        }
    }
}
