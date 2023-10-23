using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("============\nSequência de Fibonacci\n============");

            Inicio:

            Console.Write("\nQuantos elementos terá a sequência? ");
            byte quantidade = byte.Parse(Console.ReadLine());

            long[] fibonacci= new long[quantidade];
            Console.WriteLine();


            if(quantidade == 0)
            {
                Console.WriteLine("A sequência não contem elementos");
            }
            else if (quantidade > 92)
            {
                Console.WriteLine("Máximo de 92 elementos.");
            }
            else
            {
                fibonacci[0]= 1;

                for(int i = 0; i < quantidade; i++)
                {

                    if (i == quantidade - 1)
                    {
                        Console.WriteLine("[" + fibonacci[i] + "].");
                    }
                    else
                    {
                        Console.Write("[" + fibonacci[i] + "], "); 
                        fibonacci[i + 1] = i == 0 ? fibonacci[i] : fibonacci[i] + fibonacci[i - 1];
                    }

                } 

            }

            Console.Write("\nDeseja continuar? (S/N) ");
            string continuar = Console.ReadLine();
            if (continuar == "s" || continuar == "S")
            {
                goto Inicio;
            }
            
        }
    }
}
