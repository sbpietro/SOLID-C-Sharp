﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_C_Sharp.Cap3
{
    class Transportadora : IServicoDeEntrega
    {
        public double Para(string cidade)
        {
            return 5;
        }
    }
}
