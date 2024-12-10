using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exercicio11
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Qual seu salario fixo?");

            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos carros você vendeu?");

            double quantidade = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da comissao?");

            double comissao = double.Parse(Console.ReadLine());


            Console.WriteLine("Qual o valor total de suas vendas?");

            double quantidadeTotal = double.Parse(Console.ReadLine());



            double comissaoTotal = comissao * quantidade;

            double comissaoPorcentagem = quantidadeTotal * 0.05;

            double Final = salario + comissaoTotal + comissaoPorcentagem;


            Console.WriteLine("O valor total do salário é de R$ " + Final.ToString("F2"));


        }
    }
}

