using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exercicio7
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a idade em anos");

            int anos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os meses");

            int meses = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dias");

            int dias = int.Parse(Console.ReadLine());

            int total = (anos * 365) + (meses * 30) + dias;



            Console.WriteLine("A idade em dias é " + total);
        }
    }
}
