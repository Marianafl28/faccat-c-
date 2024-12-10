using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exercicio20
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor:");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor:");
            double valor2 = double.Parse(Console.ReadLine());

            if (valor1 < valor2)
            {
                Console.WriteLine( "Crescente " + valor1 + ","  + valor2);
            }
            else if (valor1 == valor2)
            {
                Console.WriteLine("Os números são iguais.");
            }
            else
            {
                Console.WriteLine("Crescente " + valor2 + "," + valor1);
            }
        }
    }
}
