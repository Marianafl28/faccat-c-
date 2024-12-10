using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exercicio33
    {
        public static void Main(string[] args)
        {
          
            Console.Write("Digite o valor 1 ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor 2 ");
            int valor2 = int.Parse(Console.ReadLine());

            if (valor1 > valor2)
            {
                Console.WriteLine("Primeiro é maior");
            }
            else if (valor2 > valor1)
            {
                Console.WriteLine("Segundo maior");
            }
            else
            {
                Console.WriteLine("Números iguais’");
            }
        }
    }
}

