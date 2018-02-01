using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_C_Sharp.Cap3
{
    class Frete : IServicoDeEntrega
    {
        public double Para(string cidade)
        {
            if ("BH".Equals(cidade.ToUpper()))
                return 15;
            return 30;
        }
    }
}