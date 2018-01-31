using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_C_Sharp.Cap2
{
    public class NotaFiscal
    {
        public double Valor { get; private set; }
        public double Imposto { get; private set; }
        public NotaFiscal(double valor, double imposto)
        {
            this.Valor = valor;
            this.Imposto = imposto;
        }
    }
}