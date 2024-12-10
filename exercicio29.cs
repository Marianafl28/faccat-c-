using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exercicio29
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            double numero = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um numero");
            double numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um numero");
            double numero3 = double.Parse(Console.ReadLine());

            if (numero == numero2 || numero == numero3 || numero2 == numero3)
            {
                Console.WriteLine("Numeros iguais");
            }
            else
            {
               
                double somaDosMaiores;

                if (numero < numero2 && numero < numero3)
                {
                    somaDosMaiores = numero2 + numero3;
                }
                else if (numero2 < numero && numero2 < numero3)
                {
                    somaDosMaiores = numero + numero3;
                }
                else
                {
                    somaDosMaiores = numero + numero2;
                }


                Console.WriteLine("A soma dos dois numeros maiores é de " + somaDosMaiores);

            }
        }
    }
}
