using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_C_Sharp.Cap1
{
    public abstract class Cargo
    {
        public IRegra Regra { get; private set; }

        public Cargo(IRegra regra)
        {
            this.Regra = regra;
        }
    }
}
