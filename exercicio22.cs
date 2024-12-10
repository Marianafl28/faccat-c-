using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exercicio22
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero de horas trabalhados");
            int horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o salario por hora");
            int salarioHora = int.Parse(Console.ReadLine());

            double horasSemanais = 40;
            double horasMensais = horasSemanais * 4;

            double salarioTotal;

            if (horasTrabalhadas > horasMensais)
            {
                double horasExtras = horasTrabalhadas - horasMensais;
                double ValorExtra = salarioHora * 1.5;
                salarioTotal = (horasMensais * salarioHora) + (horasExtras * ValorExtra);
            }
            else
            {
                salarioTotal = horasTrabalhadas * salarioHora;
            }
            Console.WriteLine("O salario total é de " + salarioTotal);
        }
    }
}