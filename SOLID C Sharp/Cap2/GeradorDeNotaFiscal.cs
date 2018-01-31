using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_C_Sharp.Cap2
{
    class GeradorDeNotaFiscal
    {
        private IList<IAcao> acoes;

        public GeradorDeNotaFiscal(IList<IAcao> acoes)
        {
            this.acoes = acoes;
        }

        public NotaFiscal Gera(Fatura fatura)
        {
            double valor = fatura.ValorMensal;
            NotaFiscal notaFiscal = new NotaFiscal(valor, ImpostoSimplesSobre(valor));
            foreach (var item in acoes)
            {
                item.Executa(notaFiscal);
            }

            return notaFiscal;
        }

        private double ImpostoSimplesSobre(double valor)
        {
            return valor * 0.5;
        }
    }
}
