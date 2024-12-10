using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exercicio28
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            double numero = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um numero");
            double numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um numero");
            double numero3 = double.Parse(Console.ReadLine());

            if (numero == numero2 && numero == numero3)
            {
                Console.WriteLine("Os números são iguais.");
            }
            else if (numero > numero2 && numero > numero3)
            {
                Console.WriteLine("O primeiro número é o maior");
            }
            else if (numero2 > numero && numero2 > numero3)
            {
                Console.WriteLine("O segundo número é o maior");
            }
            else
            {
                Console.WriteLine("O terceiro número é o maior");
            }

        }
    }
}
