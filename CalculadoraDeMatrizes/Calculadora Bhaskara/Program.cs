using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Bhaskara
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            Inicio:

            Console.Clear();
            Console.WriteLine("============\nEquações do Segundo Grau\n============");

            Console.WriteLine("\nConsidere uma equação do segundo grau do tipo ax²+bx+c = 0, com a, b e c números reais e a difrente de 0.\n");

            double[] variaveisABC = new double[3];

            Console.Write("Insira o valor de A: ");
            variaveisABC[0] = double.Parse(Console.ReadLine());

            Console.Write("Insira o valor de B: ");
            variaveisABC[1] = double.Parse(Console.ReadLine());

            Console.Write("Insira o valor de C: ");
            variaveisABC[2] = double.Parse(Console.ReadLine());


            double delta = Math.Pow(variaveisABC[1], 2) - 4 * variaveisABC[0] * variaveisABC[2];
            double[] resultado;

            if (delta < 0)
            {
                delta *= -1;

                double parteReal = (-1 * variaveisABC[1]) / (2 * variaveisABC[0]);

                double parteImaginaria1 = (Math.Sqrt(delta)) / (2 * variaveisABC[0]);
                double parteImaginaria2 = (-1 * Math.Sqrt(delta)) / (2 * variaveisABC[0]);

                string numeroComplexo1 = parteReal + "+" + parteImaginaria1 + "i";
                string numeroComplexo2 = parteReal + "+" + parteImaginaria2 + "i";

                Console.WriteLine("\nA solução da equação é : [ " + numeroComplexo1 + " , " + numeroComplexo2 + " ]");

            }
            else if (delta == 0)
            {
                resultado = new double[1];
                resultado[0] = (-1 * variaveisABC[1]) / (2 * variaveisABC[0]);

                Console.WriteLine("\nA solução da equação é : " + resultado[0]);
            }
            else
            {
                resultado = new double[2];
                resultado[0] = (-1 * variaveisABC[1]) + Math.Sqrt(delta) / (2 * variaveisABC[0]);
                resultado[1] = (-1 * variaveisABC[1]) - Math.Sqrt(delta) / (2 * variaveisABC[0]);

                Console.WriteLine("\nA solução da equação é : [ " + resultado[0] + " , " + resultado[1] + " ]");
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
