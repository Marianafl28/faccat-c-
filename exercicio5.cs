using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exercicio5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");

            int numero = int.Parse(Console.ReadLine());

            int antecessor = numero - 1;

            Console.WriteLine("O numero antes de " + numero + " é o numero " + antecessor);
        }
    }
}





