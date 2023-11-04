using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos
{
    internal class Program
    {
        static string txtDoNumero, txtDeBusca, letrasProibidas = "ABEFGHJKLNOPQRSTUWYZ\\'!¹@²#³$£%¢¨¬&*()-_+=§ ,<>.:;?/°^~`´{[ª}]º|\"";
        static ulong numero, numeroDeBusca;
        static bool contemApenasValidos;

        //static SortedList<ulong, string> conversorRomano = new SortedList<ulong, string>()
        //{
        //    {1, "I" }, {2, "II" }, {3, "III" }, {4, "IV"}, {5, "V"}, {6, "VI"}, {7, "VII"}, {8, "VIII"}, {9,"IX"},
        //    {10, "X" }, {20, "XX" }, {30, "XXX" }, {40, "XL"}, {50, "L"}, {60, "LX"}, {70, "LXX"}, {80, "LXXX"}, {90,"XC"},
        //    {100, "C" }, {200, "CC" }, {300, "CCC" }, {400, "CD"}, {500, "D"}, {600, "DC"}, {700, "DCC"}, {800, "DCCC"}, {900,"CM"},
        //    {1000, "M" }
        //};


        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo ao sistema de conversão de números romanos.");

            Inicio:

            Console.Write("\nDigite o número que deseja converter: ");

            txtDoNumero = Console.ReadLine().ToUpper();

            if (ulong.TryParse(txtDoNumero, out numero))
            {
                if(numero < 1 || numero > 1000)
                {
                    Console.WriteLine("Digite um número entre 1 e 1000.");
                    goto Inicio;
                }
                else
                {
                    
                }
            }
            else
            {
                contemApenasValidos = true;

                foreach (char letra in letrasProibidas)
                {
                    if (txtDoNumero.Contains(letra))
                    {
                        contemApenasValidos = false;
                    }
                }

                if (!contemApenasValidos)
                {
                    Console.WriteLine("Digite algarismos romanos ou indo-arábicos válidos.");
                    goto Inicio;
                }
                else
                {
                    
                }
            }
        }
    }
}
