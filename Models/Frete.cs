using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Models
{
    public class Frete
    {
        // VAI SERVIR QUANDO O USUÁRIO SELECIONAR DESTINO - PARA PRECISAR IR AO BANCO DIRETO COM JS
        public int CEP { get; set; }

        //CODCARRINHO - HASHCODE - MD5
        public string CodCarrinho { get; set; }
        public List<ValorPrazoFrete> ListaValores { get; set; }
    }
}
