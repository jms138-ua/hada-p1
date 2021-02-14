using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            char bool_bucle = 's';
            do
            {
                Console.Write("\nUnidad de conversion y cantidad (s/m n) ");
                string input = Console.ReadLine();

                double result;
                if (input[0] == 's')
                    result = HadaP1.Seconds2Minutes(double.Parse(input.Substring(2)));
                else if (input[0] == 'm')
                    result = HadaP1.Minutes2Seconds(double.Parse(input.Substring(2)));
                else
                {
                    Console.WriteLine("No existe esa medida");
                    continue;
                }

                Console.WriteLine("Resultado = {0}", result);
                Console.Write("Quieres realizar mas conversiones? (s/n) ");
                bool_bucle = char.Parse(Console.ReadLine());

            } while (bool_bucle == 's');
        }
    }
}
