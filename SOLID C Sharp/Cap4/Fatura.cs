using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_C_Sharp.Cap4
{
    public class Fatura
    {
        public string Cliente { get; private set; }
        public double Valor { get; set; }
        public bool Pago { get; private set; }
        private IList<Pagamento> pagamentos;
        public Fatura(string cliente, double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.pagamentos = new List<Pagamento>();
            this.Pago = false;
        }
        public void AdicionaPagamento(Pagamento pagamento)
        {
            this.pagamentos.Add(pagamento);
            if (valorTotalDosPagamentos() >= Valor)
                this.Pago = true;
        }
        private double valorTotalDosPagamentos()
        {
            double total = 0;

            foreach (var pagamento in pagamentos)
            {
                total += pagamento.Valor;
            }
            return total;
        }
    }
}