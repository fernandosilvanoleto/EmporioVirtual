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
            string Email = (value as string).Trim();

            //Obter o Repository do Colaborador
            IColaboradorRepository _colaboradorrepository = (IColaboradorRepository)validationcontext.GetService(typeof(IColaboradorRepository));

            //Fazer Verificação de email único na tabela
            List<Colaborador> colaboradores = _colaboradorrepository.ObterColaboradorPorEmail(Email);

            Colaborador objColaborador = (Colaborador)validationcontext.ObjectInstance;

            // TODO - Colaborador > 1 - REJEITAR
            if (colaboradores.Count > 1)
            {
                return new ValidationResult("E-mail já existente!!!");
            }

            //TODO - Colaborador == 1 && objColaborador.Id != colaborador(0).Id
            if (colaboradores.Count == 1 && objColaborador.Id != colaboradores[0].Id)
            {
                return new ValidationResult("E-mail já existente!!!");
            }
            return ValidationResult.Success;
        }
    }
}
