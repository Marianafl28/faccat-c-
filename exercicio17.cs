using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exercicio17
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Digite a nota 1");

            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 2");

            double nota2 = double.Parse(Console.ReadLine());

            double final = ( nota1 + nota2) / 2;


            if (final >= 6 )
            {
                Console.WriteLine("Aprovado " + final);
               
            }
            else
            {
                Console.WriteLine("Reprovado " + final);
            }
        }
    }
}
