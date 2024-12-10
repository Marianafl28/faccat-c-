using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exercicio19
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor:");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor:");
            double valor2 = double.Parse(Console.ReadLine());

            if (valor1 > valor2)
            {
                Console.WriteLine("O número 1 é maior: " + valor1);
            }
            else if (valor1 == valor2)
            {
                Console.WriteLine("Os números são iguais.");
            }
            else
            {
                Console.WriteLine("O número 2 é maior: " + valor2);
            }
        }
    }
}
