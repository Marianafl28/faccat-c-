using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exercicio12
    {
            public static void Main(string[] args)
            {

                Console.WriteLine("Fahrenheit ou Celsius (f ou c )");

                char temperatura = char.Parse(Console.ReadLine());


            if (temperatura == 'f' )
                {
                    Console.WriteLine("Digite a temperatura em Fahrenheit:");
                    double fahrenheit = double.Parse(Console.ReadLine());
                    double celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine("A temperatura em Celsius é " + celsius);
                }
                else
                {
                    Console.WriteLine("Digite a temperatura em Celsius:");
                    double celsius = double.Parse(Console.ReadLine());
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine("A temperatura em Fahrenheit é " + fahrenheit);
                }
            }
        }
    }

