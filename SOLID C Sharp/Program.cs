using SOLID_C_Sharp.Cap1;
using SOLID_C_Sharp.Cap2;
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

            EnviadorDeEmail email = new EnviadorDeEmail();
            NotaFiscalDAO dao = new NotaFiscalDAO();
            IList<IAcao> acoes = new List<IAcao>();
            acoes.Add(new EnviadorDeEmail());
            acoes.Add(new NotaFiscalDAO());
            acoes.Add(new SAP());
            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(acoes);
            Fatura fatura = new Fatura(200, "Stefano");
            gerador.Gera(fatura);
            Console.ReadKey();

            #endregion

            #region Capitulo 3 - Classes Abertas, Open Closed e Depedency Inversion Principles



            #endregion

            #region Capitulo 4 - Encapsulamento



            #endregion

            #region Capitulo 5 - Herança



            #endregion
        }
    }
}
