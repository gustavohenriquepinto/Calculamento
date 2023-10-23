using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematica m = new Matematica();

            
           
           

            #region Matriz B

            byte linhasB, colunasB;

            Console.WriteLine("\nDefina o número de linhas e colunas da matriz B:");
            Console.Write("Linhas:");
            linhasB = byte.Parse(Console.ReadLine());
            Console.Write("Colunas:");
            colunasB = byte.Parse(Console.ReadLine());

            int[,] matrizB = new int[linhasB, colunasB];

            for (int linhas = 0; linhas < linhasB; linhas++)
            {
                for (int colunas = 0; colunas < colunasB; colunas++)
                {
                    Console.Write("Digite o valor de [" + linhas + "," + colunas + "]");
                    matrizB[linhas, colunas] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nA Matriz B é:");
            for (int linhas = 0; linhas < linhasB; linhas++)
            {
                for (int colunas = 0; colunas < colunasB; colunas++)
                {
                    Console.Write("[" + matrizA[linhas, colunas] + "]");
                    if (colunas == colunasB - 1)
                    {
                        Console.Write("\n");
                    }
                }
            }
            Console.Write("\nIsso está correto? (\"Não\" para reiniciar): ");
            string matrizBCorreta = Console.ReadLine();

            if (matrizBCorreta == "Não" || matrizBCorreta == "Nao" || matrizBCorreta == "nao" || matrizBCorreta == "nao")
            {
                goto Continuar;
            }
            #endregion

            
    }
}
