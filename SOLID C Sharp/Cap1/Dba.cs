using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_C_Sharp.Cap1
{
    class Dba : Cargo
    {
        public Dba(IRegra regra) : base(regra)
        {

        }
    }
}