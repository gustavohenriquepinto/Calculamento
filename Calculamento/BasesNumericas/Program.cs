using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasesNumericas
{
    internal class Program
    {
        
        static byte base1, base2;
        static string txt1, txt2, algarismos = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static long num1, num2;

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo ao sistema de cáculos com bases numéricas.\n");
            
            Inicio:
            
            Console.Write("Defina a base do número a converter: ");
            if (!BaseValida(Console.ReadLine()))
            {
                Console.WriteLine("\nA base deve ser um número entre 2 e 36.");
                goto Inicio;
            }

            Console.Write("Defina o número a converter: ");
            txt1 = Console.ReadLine();
                    
            Console.Write("Defina a base do resultado: ");
            if (byte.TryParse(Console.ReadLine(), out base1))
            {
            }
        }

        static bool BaseValida(string txtBase)
        {
            if (!byte.TryParse(txtBase, out base1))
            {
                return false;
            }
            else if (base1 < 2 || base1 > 36)
            {
                return false;
            }
            return true;
        }

        static bool NumeroValido(string txtNumero)
        {
            foreach (char algarismo in txtNumero)
            {
                if (algarismos.IndexOf(algarismo) > base1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
