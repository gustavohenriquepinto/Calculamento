
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inicio:

            Console.Clear();
            Console.WriteLine("============\nNúmeros Fatoriais\n============");


            Console.Write("\nCalcular o fatorial do número: ");
            int numero = int.Parse(Console.ReadLine());

            long fatorial = Fatorial(numero);

            if (fatorial == 0)
            {
                Console.WriteLine("O número digitado não é válido.");
            }
            else
            {
                Console.WriteLine("O resultado é: " + fatorial);
            }
            


            Console.Write("\nDeseja continuar? (S/N) ");
            string continuar = Console.ReadLine();
            if (continuar == "s" || continuar == "S")
            {
                goto Inicio;
            }
        }

        static long Fatorial(int calcular)
        {
            if (calcular > 20)
            {
                return 0;
            }
            else if (calcular > 1)
            {
                return calcular * Fatorial(calcular - 1);
            }
            else if (calcular > -1)
            {
                return 1;
            }
            return 0;
        }
    }
}
