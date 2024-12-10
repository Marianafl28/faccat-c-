using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exercicio16
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Quantas maçãs você vai comprar ?");

            double macas = double.Parse(Console.ReadLine());

            double preco;

            if (macas >= 12)
            {
                preco = 1.00;
            }
            else
            {
                preco = 1.30;
            }

            double total = macas * preco;

            Console.WriteLine("O total será " + total);

        }
    }
}

