using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exercicio8
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero tatal de eleitores");

            int total = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total branco");

            int branco = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total nulo");

            int nulos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total validos");

            int valido = int.Parse(Console.ReadLine());

            int fim = branco + nulos + valido;

            double percentualBrancos = (double) branco / total * 100;
            double percentualNulos = (double)nulos / total * 100;
            double percentualValidos = (double)valido / total * 100;

            Console.WriteLine("O total é de " + fim);
            Console.WriteLine("Votos brancos " + percentualBrancos);
            Console.WriteLine("Votos nulos " + percentualNulos);
            Console.WriteLine("Votos validos " + percentualValidos);



           
        }
    }
}
