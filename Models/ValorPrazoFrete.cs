﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Models
{
    public class ValorPrazoFrete
    {
        public string TipoFrete { get; set; }
        public string CodigoTipoFrete { get; set; }
        public double Valor { get; set; }
        public int Prazo { get; set; }
    }
}
