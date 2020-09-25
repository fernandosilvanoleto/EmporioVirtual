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
                ValorDosPacotesPorFrete.Add(await CalcularValorPrazoFrete(cepDestino, tipoFrete, pacote));
            }
            ValorPrazoFrete ValorDosFretes = ValorDosPacotesPorFrete
                .GroupBy(a => a.TipoFrete)
                .Select(list => new ValorPrazoFrete
                {
                    TipoFrete = list.First().TipoFrete,
                    Prazo = list.Max(c=>c.Prazo),
                    Valor = list.Sum(c=>c.Valor)
                }).ToList().First();

            return ValorDosFretes;
        }

        private async Task<ValorPrazoFrete> CalcularValorPrazoFrete(string cepDestino, string tipoFrete, Pacote pacote)
        {
            var cepOrigem = _configuration.GetValue<string>("CepOrigem");
            var maoPropria = _configuration.GetValue<string>("MaoPropria");
            var avisoRecebimento = _configuration.GetValue<string>("AvisoRecebimento");
            var diametro = Math.Max(Math.Max(pacote.Comprimento, pacote.Largura), pacote.Altura);

           cResultado resultado = await _servico.CalcPrecoPrazoAsync("", "", tipoFrete, cepOrigem, cepDestino, pacote.Peso.ToString(), 1, pacote.Comprimento, pacote.Altura, pacote.Largura, diametro, maoPropria, 0, avisoRecebimento);

            if (resultado.Servicos[0].Erro == "0")
            {
                // TUDO CERTO - OK
                return new ValorPrazoFrete()
                {
                    TipoFrete = tipoFrete,
                    Prazo = int.Parse(resultado.Servicos[0].PrazoEntrega),
                    Valor = double.Parse(resultado.Servicos[0].Valor.Replace(".", "").Replace(",", "."))
                };
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
