using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exercicio15
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Qual o numero ?");

            double numero = double.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                Console.WriteLine("Numero positivo");
            }
            else
            {
                Console.WriteLine("Numero negativo");
            }

        }
    }
}

