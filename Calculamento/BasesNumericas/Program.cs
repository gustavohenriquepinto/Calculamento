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
        
        static byte base1, base2, operacao;
        static string txt1, txt2, alfabeto = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static long num1, num2;
        static char sair;

        //static char[] alfabeto = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        
        static void Main(string[] args)
        {
            

            Inicio:

            Console.Clear();
            Console.WriteLine("Bem-vindo ao sistema de cáculos com bases numéricas.");

        #region PrimeiroNumero
            Console.Write("\nDefina a base do primeiro número: ");
            if (!byte.TryParse(Console.ReadLine(), out base1))
            {
                Console.WriteLine("Por favor, utiliza apenas números.");
                goto Reiniciar;
            }
            else if (base1 > 36 || base1 < 2)
            {
                Console.WriteLine("Por favor, utilize números inteiros entre 2 e 36.");
                goto Reiniciar;
            }

            Console.Write("\nDefina o valor do primeiro número: ");
            txt1 = Console.ReadLine().ToUpper().Trim();

            if (ContemApenasValidos(base1, txt1))
            {
                num1 = ConverterBase10(base1, txt1);
            }
            else
            {
                Console.WriteLine("Você inseriu caracteres inválidos.");
                goto Reiniciar;
            }
            #endregion

            //Console.WriteLine(num1.ToString());

            Console.WriteLine("\nDeseja realizar qual operação?");
            Console.WriteLine("1 - Conversão de Base");
            Console.WriteLine("2 - Soma");
            Console.WriteLine("3 - Subtração");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Divisão");

            if(byte.TryParse(Console.ReadLine(), out operacao))
            {
                switch (operacao)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                }
            }
            else
            {

            }
            
            

        Reiniciar:

            Console.Write("\nVocê deseja sair (S/N)?");
            sair = char.Parse(Console.ReadLine());
            if(sair !='s' && sair != 'S')
            {
                goto Inicio;
            }
        }

        static bool ContemApenasValidos(byte baseDoNumero, string textoDoNumero)
        {
            for (int letraDoAlfabeto = 0; letraDoAlfabeto < alfabeto.Length; letraDoAlfabeto++)
            {
                if (textoDoNumero.Contains(alfabeto[letraDoAlfabeto]) && letraDoAlfabeto > baseDoNumero)
                {
                    return false;
                }
            }

            return true;
        }

        static long ConverterBase10(byte baseDoNumero, string textoDoNumero)
        {
            long valorDoNumero = 0;

            for(int caractereDoNumero = 0; caractereDoNumero < textoDoNumero.Length; caractereDoNumero++)
            {
                valorDoNumero += alfabeto.IndexOf(textoDoNumero[caractereDoNumero]) * (long)Math.Pow(baseDoNumero, (textoDoNumero.Length - (1 + caractereDoNumero)));
            }

            return valorDoNumero;
        }
    }
}
