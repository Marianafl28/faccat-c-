using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exercicio13
    {
            public static void Main(string[] args)
            {

                Console.WriteLine("Qual a nota 1?");

                double nota1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Qual a nota 2?");

                double nota2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Qual a nota 2?");

                double nota3 = double.Parse(Console.ReadLine());

            double finalNota1 = nota1 * 2;

            double finalNota2 = nota2 * 3;

            double finalNota3 = nota3 * 5;

            double total = (finalNota1 + finalNota2 + finalNota3)/ 10;

            Console.WriteLine("A media final é de " + total);



        }
        }
    }
