using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace faccat
{
    internal class exercicio30
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um numero ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite um numero  ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.Write("Digite um numero  ");
            int numero3 = int.Parse(Console.ReadLine());

            int menor;
            int meio;
            int maior;

            if (numero1 < numero2 && numero1 < numero3)
            {
                menor = numero1;
                if (numero2 < numero3)
                {
                    meio = numero2;
                    maior = numero3;
                }
                else
                {
                    meio = numero3;
                    maior = numero2;
                }
            }
            else if (numero2 < numero1 && numero2 < numero3)
            {
                menor = numero2;
                if (numero1 < numero3)
                {
                    meio = numero1;
                    maior = numero3;
                }
                else
                {
                    meio = numero3;
                    maior = numero1;
                }
            }
            else
            {
                menor = numero3;
                if (numero1 < numero2)
                {
                    meio = numero1;
                    maior = numero2;
                }
                else
                {
                    meio = numero2;
                    maior = numero1;
                }
            }
            Console.WriteLine("Os numeros em ordem crescente são " +  menor + "," + meio + "," + maior);
        }

    }
}
    

