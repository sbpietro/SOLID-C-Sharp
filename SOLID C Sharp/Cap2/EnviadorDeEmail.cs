using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_C_Sharp.Cap2
{
    public class EnviadorDeEmail : IAcao
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Enviando e-mail");
        }
    }
}