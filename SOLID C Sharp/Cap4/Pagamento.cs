namespace SOLID_C_Sharp.Cap4
{
    public class Pagamento
    {
        public double Valor { get; private set; }
        private MeioDePagamento MeioDePagamento;
        public Pagamento(double valor, MeioDePagamento meioDePagamento)
        {
            this.Valor = valor;
            this.MeioDePagamento = MeioDePagamento.BOLETO;
        }
    }
}