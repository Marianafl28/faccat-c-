using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exercicio10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do carro");

            int fabricacao = int.Parse(Console.ReadLine());

            double distribuidor = 28.0;
            double impostos = 45.0;

            double Valordistribuidor = fabricacao * distribuidor / 100;
            double ValorImpostos = fabricacao * impostos / 100;

            double fim = fabricacao + Valordistribuidor + ValorImpostos;

            Console.WriteLine("O valor final do carro é de " + fim);

        }
    }
}
