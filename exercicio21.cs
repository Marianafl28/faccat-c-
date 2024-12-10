using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exercicio21
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a hora que você começou o jogo");
            int comeco = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a hora que você acabou o jogo");
            int fim = int.Parse(Console.ReadLine());

            int total;

            if (comeco < fim)
            {
                total = fim - comeco;
            }
            else
            {
                total = (24 - comeco) + fim;
        }
            Console.WriteLine("O jogo durou " + total);
}
    }
}

