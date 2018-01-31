using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_C_Sharp.Cap2
{
    class NotaFiscalDAO : IAcao
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Persistindo nota");
        }
    }
}