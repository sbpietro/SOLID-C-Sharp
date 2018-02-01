using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_C_Sharp.Cap3
{
    public class Compra
    {
        public string Cidade { get; private set; }

        public double Valor { get; private set; }
        public Compra(double valor, string cidade)
        {
            this.Valor = valor;
            this.Cidade = cidade;
        }
        
    }
}