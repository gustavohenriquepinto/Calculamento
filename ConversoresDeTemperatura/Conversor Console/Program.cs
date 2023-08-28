using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONVERSOR DE TEMPERATURAS\n");

            double Celsius, Farenheint, Kelvin;
            Celsius = 0;
            Farenheint = 0;
            Kelvin = 0;

            #region Escolha a Operação
            Console.WriteLine("Escolha a operação:\n1- De Celsius para Kelvin e Farenheint\n2- De Farenheint para Celsius e Kelvin\n3- De Kelvin para Celsius e Farenheint");
            byte Operacao = byte.Parse(Console.ReadLine());
            #endregion

            #region Calculando as variáveis
            switch (Operacao){
                case 1:
                    Console.WriteLine("\nDigite o valor em Celsius abaixo:");
                    Celsius = double.Parse(Console.ReadLine());
                    Farenheint = Celsius * 9 / 5 + 32;
                    Kelvin = Celsius + 273;    
                break;
                case 2:
                    Console.WriteLine("\nDigite o valor em Farenheint abaixo:");
                    Farenheint = double.Parse(Console.ReadLine());
                    Celsius = (Farenheint - 32) * 5 / 9;
                    Kelvin = Celsius + 273;
                    break;
                case 3:
                    Console.WriteLine("\nDigite o valor em Kelvin abaixo:");
                    Kelvin = double.Parse(Console.ReadLine());
                    Celsius = Kelvin - 273;
                    Farenheint = Celsius * 9 / 5 + 32;
                break;
            }
            #endregion

            #region Apresentando o Resultado
            Console.WriteLine("\nIsso representa " + Celsius + "°C na escala Celsius, " + Farenheint + "°F na escala Farenheint, e " + Kelvin + "K na escala Kelvin");
            #endregion
        }
    }
}
