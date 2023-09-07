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
            Inicio:

            Console.Clear();
            Console.WriteLine("============\nCalculadora de Matrizes\n============\n");

            #region Matriz A

            byte linhasA, colunasA;

            Console.WriteLine("Defina o número de linhas e colunas da matriz A:");
            Console.Write("Linhas:");
            linhasA = byte.Parse(Console.ReadLine());
            Console.Write("Colunas:");
            colunasA = byte.Parse(Console.ReadLine());

            int[,] matrizA = new int[linhasA, colunasA];

            for(int linhas = 0; linhas<linhasA; linhas++)
            {
                for(int colunas = 0; colunas<colunasA; colunas++)
                {
                    Console.Write("Digite o valor de ["+linhas+","+colunas+"]");
                    matrizA[linhas, colunas] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nA Matriz A é:");
            for (int linhas = 0; linhas < linhasA; linhas++)
            {
                for (int colunas = 0; colunas < colunasA; colunas++)
                {
                    Console.Write("["+ matrizA[linhas,colunas] + "]");
                    if (colunas == colunasA - 1)
                    {
                        Console.Write("\n");
                    }
                }
            }
            Console.Write("\nIsso está correto? (\"Não\" para reiniciar): ");
            string matrizACorreta = Console.ReadLine();

            if(matrizACorreta=="Não" || matrizACorreta=="Nao"|| matrizACorreta=="nao"|| matrizACorreta == "nao")
            {
                goto Continuar;
            }
            #endregion

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

            #region Operãção
            Console.WriteLine("\nEscolha entre uma das operações abaixo:\n");
            Console.WriteLine("1- Soma de Matrizes");

            byte operacao = byte.Parse(Console.ReadLine());

            switch (operacao)
            {
                default:
                    Console.WriteLine("\nEssa operação não está disponível");
                    goto Continuar;

                case 1:

                    if (linhasA != linhasB || colunasA != colunasB)
                    {
                        Console.WriteLine("Só é possível realizar essa operação se o número de linhas e colunas for o mesmo.");
                        
                    }
                    else
                    {
                        int[,] matrizC = new int[linhasA, colunasA];

                        for (int linhas = 0; linhas < linhasA; linhas++)
                        {
                            for (int colunas = 0; colunas < colunasA; colunas++)
                            {
                                matrizC[linhas, colunas] = matrizA[linhas, colunas] + matrizB[linhas, colunas];
                            }
                        }
                        
                        Console.WriteLine("O resultado é:");
                        for (int linhas = 0; linhas < linhasA; linhas++)
                        {
                            for (int colunas = 0; colunas < colunasA; colunas++)
                            {
                                Console.Write("[" + matrizC[linhas, colunas] + "]");
                                if (colunas == colunasA - 1)
                                {
                                    Console.Write("\n");
                                }
                            }
                        }
                    }
                    goto Continuar;

            }
        #endregion


        Continuar:
            Console.Write("\nVocê deseja reiniciar? (\"Sim\" para reiniciar)");
            string continuar = Console.ReadLine();

            if (continuar == "sim" || continuar == "Sim")
            {
                goto Inicio;
            }
        }
    }
}
