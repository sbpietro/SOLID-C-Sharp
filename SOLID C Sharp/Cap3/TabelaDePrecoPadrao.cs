﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_C_Sharp.Cap3
{
    class TabelaDePrecoPadrao : ITabelaDePreco
    {
        public double DescontoPara(double valor)
        {
            if (valor > 5000)
                return 0.03;
            if (valor > 1000)
                return 0.03;
            return 0;
        }
    }
}