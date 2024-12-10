using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exercicio14
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Qual o numero ?");

            double numero = double.Parse(Console.ReadLine());

         if (numero >= 10) {
                Console.WriteLine("Numero maior que 10");
            }
            else
            {
                Console.WriteLine("Não é maior que 10");
            }

        }
    }
}

