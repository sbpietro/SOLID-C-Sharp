using SOLID_C_Sharp.Cap1;
using SOLID_C_Sharp.Cap2;
using SOLID_C_Sharp.Cap3;
using SOLID_C_Sharp.Cap4;
using SOLID_C_Sharp.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Capitulo 1 - Classes Coesas

            //CalculadoraDeSalario calculadoraDeSalario = new CalculadoraDeSalario();
            //Funcionario funcionario = new Funcionario(new Desenvolvedor(new DezOuVintePorcento()), 2000);
            //double resultado;

            //resultado = calculadoraDeSalario.Calcula(funcionario);
            //Console.WriteLine("O salário líquido é: " + resultado);
            //Console.ReadKey();


            #endregion

            #region Capitulo 2 - Acoplamento

            //EnviadorDeEmail email = new EnviadorDeEmail();
            //NotaFiscalDAO dao = new NotaFiscalDAO();
            //IList<IAcao> acoes = new List<IAcao>();
            //acoes.Add(new EnviadorDeEmail());
            //acoes.Add(new NotaFiscalDAO());
            //acoes.Add(new SAP());
            //GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(acoes);
            //Fatura fatura = new Fatura(200, "Stefano");
            //gerador.Gera(fatura);
            //Console.ReadKey();

            #endregion

            #region Capitulo 3 - Classes Abertas, Open Closed e Depedency Inversion Principles

            //Compra compra = new Compra(500, "bh");
            //CalculadoraDePrecos calculadora = new CalculadoraDePrecos(new TabelaDePrecoPadrao(), new Transportadora());

            //double resultado = calculadora.Calcula(compra);

            //Console.WriteLine("O preço da compra é R$ " + resultado);
            //Console.ReadKey();

            #endregion

            #region Capitulo 4 - Encapsulamento

            //List<Boleto> boletos = new List<Boleto>();
            //boletos.Add(new Boleto(200));
            //boletos.Add(new Boleto(300));
            //boletos.Add(new Boleto(400));

            //Cap4.Fatura fatura = new Cap4.Fatura("Stefano", 900);

            //ProcessadorDeBoletos processador = new ProcessadorDeBoletos();
            //processador.Processa(boletos, fatura);
            //Console.WriteLine(fatura.Pago);
            //Console.ReadKey();

            #endregion

            #region Capitulo 5 - Herança

            IList<ContaComum> contas = ContasDoBanco();

            foreach (var conta in contas)
            {
                conta.somaInvestimento();

                Console.WriteLine("Novo saldo: " + conta.Saldo);
            }
            Console.ReadLine();

            

            #endregion
        }
        private static IList<ContaComum> ContasDoBanco()
        {
            List<ContaComum> contas = new List<ContaComum>();
            contas.Add(umaContaComum(100));
            contas.Add(umaContaComum(150));
            contas.Add(umaContaEstudante(100));
            return contas;
        }

        private static ContaComum umaContaComum(double saldo)
        {
            ContaComum conta = new ContaComum();
            conta.Deposita(saldo);
            return conta;
        }

        private static ContaEstudante umaContaEstudante(double saldo)
        {
            ContaEstudante conta = new ContaEstudante();
            conta.Deposita(saldo);
            return conta;
        }


    }
}
