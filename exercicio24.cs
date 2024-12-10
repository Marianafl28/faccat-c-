using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exercicio24
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Qual seu salario fixo?");
            double fixo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor total das vendas efetuadas");
            double total = double.Parse(Console.ReadLine());

            double comissao;

            if (total <= 1500)
            {
                comissao = total * 0.03;
            }
            else
            {
                comissao = 1500 * 0.03 % +(total - 1500) * 0.05;
            }

            double salarioFinal = fixo + comissao;

            Console.WriteLine("O seu salario final é de " + salarioFinal);
        }
    }
}
