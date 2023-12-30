using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos
{
    sealed class Program
    {
        static void Main(string[] args)
        {
            int valorNumero;
            string textoNumero, textoRetorno = "", textoApoio;
            char tipoConversao = 'A';

            Dictionary<int, string> algarismosRomanos = new Dictionary<int, string>()
            {
                {1, "I"}, {2, "II"}, {3, "III"}, {4, "IV"}, {5, "V"}, {6, "VI"}, {7, "VII"}, {8, "VIII"}, {9, "IX"},
                {10, "X"}, {20, "XX"}, {30, "XXX"}, {40, "XL"}, {50, "L"}, {60, "LX"}, {70, "LXX"}, {80, "LXXX"}, {90, "XC"},
                {100, "C"}, {200, "CC"}, {300, "CCC"}, {400, "CD"}, {500, "D"}, {600, "DC"}, {700, "DCC"}, {800, "DCCC"}, {900, "CM"},
                {1000, "M"}, {2000, "MM"}, {3000, "MMM"}
            };

            Inicio:
            Console.WriteLine("Bem-vindo ao sistema de conversão de números romanos.");
            Console.Write("Digite o número a converter: ");
            textoNumero = Console.ReadLine();

            if (int.TryParse(textoNumero, out valorNumero))
            {
                tipoConversao = 'A';
            }
            else
            {
                Console.WriteLine("\nPor enquanto, apenas de algarismos indoarábicos para romanos.\n");
                goto Inicio;
            }

            switch (tipoConversao)
            {
                case 'A':

                    if(valorNumero >= 4000 || valorNumero <= 0)
                    {
                        Console.WriteLine("\nEscolha valores maiores que 0 e menores que 4000.\n");
                        goto Inicio;
                    }

                    for (int letra = 0; letra < textoNumero.Length; letra++)
                    {
                        if(algarismosRomanos.TryGetValue(textoNumero[letra] * (textoNumero.Length - 1 - letra), out textoApoio)){
                            textoRetorno += textoApoio;
                        }
                        else
                        {
                            Console.WriteLine("\nOcorreu um erro.\n");
                            goto Inicio;
                        }
                    }

                    Console.WriteLine(textoRetorno);
                    goto Inicio;

                    break;

                case 'B':
                    break;
                case 'C':
                    break;
            }


        }
    }
}
