using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exercicio25
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Qual o numero da sua conta?");
            double conta = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o saldo ?");
            double saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor em debito ?");
            double debito = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor em credito ?");
            double credito = double.Parse(Console.ReadLine());


            double saldoAtual = (saldo - debito + credito);

          
            if (saldoAtual >= 0 ){
                Console.WriteLine("Saldo positivo " + saldoAtual);
            }
            else
            {
                Console.WriteLine("Saldo negativo " + saldoAtual);
            }

           
        }
    }
}
