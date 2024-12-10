using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exercicio26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Qual a quantidade atual em estoque?");
            double estoque = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quantidade maxima em estoque?");
            double maxima = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quantidade minima em estoque?");
            double minima = double.Parse(Console.ReadLine());


            double quantidadeMedia = (maxima + minima)/2;


            if (estoque < quantidadeMedia)
            {
                Console.WriteLine("Não efetuar compra, tem  " + estoque + " no estoque");
            }
            else
            {
                Console.WriteLine("Efetuar compra , tem  " + estoque + " no estoque");
            }


        }
    }
}

