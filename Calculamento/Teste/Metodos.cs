using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    static class Apoio
    {
        static public byte linhasA, colunasA, linhasB, colunasB, linhasC, colunasC;

        static double[,] matrizA = null;
        static double[,] matrizB = null;
        static double[,] matrizC = null;

        static public void DefinirMatrizA()
        {
            Console.WriteLine("Defina o número de linhas e colunas da matriz A:");
            Console.Write("Linhas:");
            linhasA = byte.Parse(Console.ReadLine());
            Console.Write("Colunas:");
            colunasA = byte.Parse(Console.ReadLine());

            double[,] matrizA = new double[linhasA, colunasA];

            for (int linhas = 0; linhas < linhasA; linhas++)
            {
                for (int colunas = 0; colunas < colunasA; colunas++)
                {
                    Console.Write("Digite o valor de [" + linhas + "," + colunas + "]: ");
                    matrizA[linhas, colunas] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nA Matriz A é:");
            for (int linhas = 0; linhas < linhasA; linhas++)
            {
                for (int colunas = 0; colunas < colunasA; colunas++)
                {
                    Console.Write("[" + matrizA[linhas, colunas] + "]");
                    if (colunas == colunasA - 1)
                    {
                        Console.Write("\n");
                    }
                }
            }
            Console.Write("\nIsso está correto? (Sim/Não): ");
            string matrizACorreta = Console.ReadLine();

            if (matrizACorreta == "Não" || matrizACorreta == "Nao" || matrizACorreta == "nao" || matrizACorreta == "nao")
            {
                Reiniciar();
            }
        }
        static public void DefinirOperacao()
        {
            Console.WriteLine("\nEscolha entre uma das operações abaixo:\n");
            Console.WriteLine("1- Soma de Matrizes");

            byte operacao = byte.Parse(Console.ReadLine());

            switch (operacao)
            {
                default:
                    Console.WriteLine("\nEssa operação não está disponível");
                    Reiniciar(); break;
                case 1:
                    DefinirMatrizB();
                    SomarMatrizes();
                    break;
            }
        }
        static private void DefinirMatrizB()
        {
            Console.WriteLine("\nDefina o número de linhas e colunas da matriz B:");
            Console.Write("Linhas:");
            linhasB = byte.Parse(Console.ReadLine());
            Console.Write("Colunas:");
            colunasB = byte.Parse(Console.ReadLine());

            double[,] matrizB = new double[linhasB, colunasB];


            for (int linhas = 0; linhas < linhasB; linhas++)
            {
                for (int colunas = 0; colunas < colunasB; colunas++)
                {
                    Console.Write("Digite o valor de [" + linhas + "," + colunas + "]: ");
                    matrizB[linhas, colunas] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nA Matriz B é:");
            for (int linhas = 0; linhas < linhasB; linhas++)
            {
                for (int colunas = 0; colunas < colunasB; colunas++)
                {
                    Console.Write("[" + matrizB[linhas, colunas] + "]");
                    if (colunas == colunasB - 1)
                    {
                        Console.Write("\n");
                    }
                }
            }
            Console.Write("\nIsso está correto? (Sim/Não): ");
            string matrizACorreta = Console.ReadLine();

            if (matrizACorreta == "Não" || matrizACorreta == "Nao" || matrizACorreta == "nao" || matrizACorreta == "nao")
            {
                Reiniciar();
            }
        }
        static public void ApresentarMatrizC()
        {
            Console.WriteLine("O resultado é:");
            for (int linhas = 0; linhas < linhasC; linhas++)
            {
                for (int colunas = 0; colunas < colunasC; colunas++)
                {
                    Console.Write("[" + matrizC[linhas, colunas] + "]");
                    if (colunas == colunasC - 1)
                    {
                        Console.Write("\n");
                    }
                }
            }
        }
        static private void Reiniciar()
        {
            Console.Write("\nVocê deseja reiniciar? (Sim/Não)");
            string reiniciar = Console.ReadLine();

            if (reiniciar == "sim" || reiniciar == "Sim")
            {
                DefinirMatrizA();
            }
        }


        static private void SomarMatrizes()
        {
            if (linhasA != linhasB || colunasA != colunasB)
            {
                Console.WriteLine("Só é possível realizar essa operação se o número de linhas e colunas for o mesmo.");
            }
            else
            {
                linhasC = linhasA;
                colunasC = colunasA;

                double[,] matrizC = new double[linhasA, colunasA];

                for (int linhas = 0; linhas < linhasA; linhas++)
                {
                    for (int colunas = 0; colunas < colunasA; colunas++)
                    {
                        matrizC[linhas, colunas] = matrizA[linhas, colunas] + matrizB[linhas, colunas];
                    }
                }
            }
        }
    }
}
