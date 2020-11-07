using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Libraries.Texto
{
    public class Mascara
    {
        public static string Remover(string valor)
        {
            // MÁSCARA PARA CPF ==> AQUI FAZ O TRATAMENTO = 07/11/2020
            return valor.Replace("(", "").Replace(")", "").Replace("-", "").Replace(".", "");

        }
    }
}
