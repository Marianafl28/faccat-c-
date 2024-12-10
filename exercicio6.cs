using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exercicio6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a base do retangulo");

            int horizonte = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do retangulo");

            int altura = int.Parse(Console.ReadLine());

            int area = horizonte * altura;



            Console.WriteLine("A area do retangulo é " + area );
        }
    }
}
