using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exercicio31
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um lado ");
            int lado1 = int.Parse(Console.ReadLine());

            Console.Write("Digite um lado  ");
            int lado2 = int.Parse(Console.ReadLine());

            Console.Write("Digite um lado  ");
            int lado3 = int.Parse(Console.ReadLine());

            if (lado1 < lado2 + lado3 && lado2 < lado1 + lado3 && lado3 < lado1 + lado2)
            {
                Console.WriteLine("É triângulo.");
            }
            else
            {
                Console.WriteLine("Não é um triângulo.");
            }
        }
    }
}
