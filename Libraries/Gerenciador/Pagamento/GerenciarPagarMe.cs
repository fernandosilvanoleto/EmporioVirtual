using EmporioVirtual.Libraries.Login;
using EmporioVirtual.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Libraries.Gerenciador.Pagamento
{
    public class GerenciarPagarMe
    {
        private IConfiguration _configuration;
        private LoginCliente _loginCliente;
        public GerenciarPagarMe(IConfiguration configuration, LoginCliente loginCliente)
        {
            _configuration = configuration;
            _loginCliente = loginCliente;
        }


        public void GerarBoleto()
        {
            // FICARÁ COMO UM MÉTODO ESTÁTICO ==> NÃO CONSIGO CADASTRAR NO PAGARME SEM UM DONO DE LOJA
            // HJ É DIA 06/11/2020 = SÓ PERMITE DONOS DE LOJA A ABRIREM CONTAS
            // ENFIM

            // NÚMERO DA AULA NA UDEMY ==> 286 PARA FRENTE

            Cliente cliente = _loginCliente.GetCliente();

        }

        public object GerarPagCartaoCredito()
        {
            // MÉTODO ESTÁTICO
            return null;
        }
    }
}
