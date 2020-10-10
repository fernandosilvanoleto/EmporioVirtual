using EmporioVirtual.Models;
using EmporioVirtual.Models.Constants;
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
        private CalcPrecoPrazoWSSoap _servico;

        public WSCorreiosCalcularFrete(IConfiguration configuration, CalcPrecoPrazoWSSoap servico)
        {
            _configuration = configuration;
            _servico = servico;
        }
        ///*
        public async Task<ValorPrazoFrete> CalcularFrete(string cepDestino, string tipoFrete, List<Pacote> pacotes)
        {
            List<ValorPrazoFrete> ValorDosPacotesPorFrete = new List<ValorPrazoFrete>();

            foreach (var pacote in pacotes)
            {
                var resultado = await CalcularValorPrazoFrete(cepDestino, tipoFrete, pacote);

                if (resultado != null)
                {
                    ValorDosPacotesPorFrete.Add(resultado);
                }
                
            }

            if (ValorDosPacotesPorFrete.Count > 0)
            {
                ValorPrazoFrete ValorDosFretes = ValorDosPacotesPorFrete
                .GroupBy(a => a.TipoFrete)
                .Select(list => new ValorPrazoFrete
                {
                    TipoFrete = list.First().TipoFrete,
                    CodigoTipoFrete = list.First().CodigoTipoFrete,
                    Prazo = list.Max(c => c.Prazo),
                    Valor = list.Sum(c => c.Valor)
                }).ToList().First();

                return ValorDosFretes;
            }

            return null;
            
        }

        private async Task<ValorPrazoFrete> CalcularValorPrazoFrete(string cepDestino, string tipoFrete, Pacote pacote)
        {
            // 
            var cepOrigem = _configuration.GetValue<String>("Frete:CepOrigem");
            var maoPropria = _configuration.GetValue<String>("Frete:MaoPropria");
            var avisoRecebimento = _configuration.GetValue<String>("Frete:AvisoRecebimento");
            var diametro = Math.Max(Math.Max(pacote.Comprimento, pacote.Largura), pacote.Altura);

           cResultado resultado = await _servico.CalcPrecoPrazoAsync("", "", tipoFrete, cepOrigem, cepDestino, pacote.Peso.ToString(), 1, pacote.Comprimento, pacote.Altura, pacote.Largura, diametro, maoPropria, 0, avisoRecebimento);

            if (resultado.Servicos[0].Erro == "0")
            {
                // TUDO CERTO - OK
                return new ValorPrazoFrete()
                {
                    TipoFrete = TipoFreteConstant.GetNames(tipoFrete),
                    CodigoTipoFrete = tipoFrete,
                    Prazo = int.Parse(resultado.Servicos[0].PrazoEntrega),
                    Valor = double.Parse(resultado.Servicos[0].Valor.Replace(".", ""))
                };
            }
            else if (resultado.Servicos[0].Erro == "-888" || resultado.Servicos[0].Erro == "008")
            {
                // REFERENTE AO SEDEX10
                // SEDEX10 - não entrega naquela região
                return null;
            }
            else
            {
                // TEVE ERROS
                throw new Exception("Erro: " + resultado.Servicos[0].MsgErro);
            }

        }
        //*/
    }
}
