using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exercicio32
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o nome do do time 1 ");
            string nome1 = Console.ReadLine();

            Console.Write("Digite a quantidade de pontos do time " + nome1);
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do do time 2 ");
            string nome2 = Console.ReadLine();

            Console.Write("Digite a quantidade de pontos do time " + nome2);
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 < numero2)
            {
                Console.WriteLine("O time 2 ganhou: " + nome2);
            }
            else if (numero2 < numero1)
            {
                Console.WriteLine("O time 1 ganhou: " + nome1);
            }
            else
            {
                Console.WriteLine("Tivemos um empate");
            }
        }
    }
}
