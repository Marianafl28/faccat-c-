using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exercicio9
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero do seu salario");

            int salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total do reajuste");

            int reajuste = int.Parse(Console.ReadLine());



            int novo = salario + (salario * reajuste / 100);

     
            Console.WriteLine("O seu novo salario é de " + novo);




        }
    }
}
