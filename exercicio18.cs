using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exercicio18
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Digite o ano de seu nascimento");

            double ano = double.Parse(Console.ReadLine());


            if (ano <= 2006 )
            {
                Console.WriteLine("Pode votar " + (2024 - ano ));

            }
            else
            {
                Console.WriteLine("Não pode votar " + (2024 - ano));
            }
        }
    }
}
