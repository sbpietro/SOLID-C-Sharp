using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_C_Sharp.Cap1
{
    class Tester : Cargo
    {
        public Tester(IRegra regra) : base(regra)
        {

        }
    }
}