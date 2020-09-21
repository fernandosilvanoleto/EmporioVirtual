using EmporioVirtual.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSCorreios;

namespace EmporioVirtual.Libraries.Gerenciador.Frete
{
    public class WSCorreiosCalcularFrete
    {
        private IConfiguration _configuration;
        private CalcPrecoPrazoWSSoapClient _servico;

        public WSCorreiosCalcularFrete(IConfiguration configuration, CalcPrecoPrazoWSSoapClient servico)
        {
            _configuration = configuration;
            _servico = servico;
        }

        public void CalcularValorPrazoFrete(string cepDestion, string tipoFrete, Pacote pacote)
        {
            var cepOrigem = _configuration.GetValue<string>("CepOrigem");
            var maoPropria = _configuration.GetValue<string>("MaoPropria");
            var avisoRecebimento = _configuration.GetValue<string>("AvisoRecebimento");

            //_servico.CalcPrecoPrazoAsync("", "", tipoFrete);
        }

    }
}
