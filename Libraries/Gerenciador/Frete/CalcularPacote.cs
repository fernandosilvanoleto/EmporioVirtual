using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmporioVirtual.Models;
using EmporioVirtual.Models.ProdutoAgregador;

namespace EmporioVirtual.Libraries.Gerenciador.Frete
{
    //INJETAR CLASSE EM STARTUP - 24/09/2020
    public class CalcularPacote
    {
        //RECEBER UMA LISTA DE PRODUTOS PARA CALCULAR FRETE
        public List<Pacote> CalcularPacotesDeProduto(List<ProdutoItem> produtos)
        {
            List<Pacote> pacotes = new List<Pacote>();

            Pacote pacote = new Pacote();

            // VER PRODUTO POR PRODUTO
            foreach (var item in produtos)
            {

                // CRIAR A DIMENSÃO DO PACOTE
                for (int i = 0; i < item.QuantidadeProdutoCarrinho; i++)
                {
                    var peso = pacote.Peso = item.Peso;

                    //ADOTAR O COMPRIMENTO E A LARGURA DO MAIOR PRODUTO
                    var comprimento = (pacote.Comprimento > item.Comprimento) ? pacote.Comprimento : item.Comprimento;
                    var largura = (pacote.Largura > item.Largura) ? pacote.Largura : item.Largura;

                    var altura = pacote.Altura + item.Altura;

                    // DIMENSÃO DO PRODUTO
                    var dimensao_produto = comprimento + largura + altura;

                    // REGRAS DOS CORREIOS
                    //CRIAR NOVOS PACOTES:
                    // SE O PESO > 30kg, DIMENSÃO > 200 cm = CRIAR NOVO PACOTE

                    if (peso > 30 || dimensao_produto > 200)
                    {
                        pacotes.Add(pacote);
                        pacote = new Pacote();
                    }


                    // UM NOVO PACOTE
                    pacote.Peso = pacote.Peso + item.Peso;
                    pacote.Comprimento = (pacote.Comprimento > item.Comprimento) ? pacote.Comprimento : item.Comprimento;
                    pacote.Largura = (pacote.Largura > item.Largura) ? pacote.Largura : item.Largura;

                    pacote.Altura = pacote.Altura + item.Altura;
                }
            }

            //pacotes.Add(pacotes);

            return pacotes;
        }
    }
}
