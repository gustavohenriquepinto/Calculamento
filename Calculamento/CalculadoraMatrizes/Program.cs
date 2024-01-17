using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] matrizControle = null;
            byte operacao, final;
            bool reciclar = false;

            Console.WriteLine("=================================\nBem-vindo à Calculadora de Matrizes.\n=================================");

            Operacao:
            Console.WriteLine("O que deseja fazer?\n" +
                "1- Obter a  soma de duas matrizes\n" +
                "2- Obter a diferença de duas matrizes");

            if (byte.TryParse(Console.ReadLine(), out operacao))
            {
                matrizControle = reciclar ? matrizControle : NovaMatriz();
                switch (operacao)
                {
                    case 1:
                        
                        ApresentarMatriz(matrizControle == null ? null : SomarMatrizes(matrizControle, NovaMatriz()), out matrizControle);
                        break;
                    case 2:
                        ApresentarMatriz(matrizControle == null ? null : SubtrairMatrizes(matrizControle, NovaMatriz()), out matrizControle);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Você inseriu um caractere inválido");
            }

            reciclar = false;
            Console.WriteLine("O que deseja fazer?\n" +
                "1- Continuar calculando utilizando o resultado.\n" +
                "2- Continuar calculando do zero.\n" +
                "Qualquer outra tecla para sair.");

            if(byte.TryParse(Console.ReadLine(), out final)){
                switch (final)
                {
                    case 1:
                        reciclar = true;
                        goto Operacao;
                    case 2:
                        goto Operacao;
                }
            }

        }

        static double[,] NovaMatriz()
        {
            byte linhas, colunas;

            Console.WriteLine("\nDefina uma nova matriz.");
            Console.Write("Linhas: ");
            if(!byte.TryParse(Console.ReadLine(), out linhas)) { return null; }
            Console.Write("Colunas: ");
            if (!byte.TryParse(Console.ReadLine(), out colunas)) { return null; }

            double[,] matriz = new double[linhas, colunas];

            for (byte linha = 0; linha < linhas; linha++)
            {
                for (byte coluna = 0; coluna < colunas; coluna++)
                {
                    Console.Write("["+(linha+1)+","+(coluna+1)+"]: ");
                    if (!double.TryParse(Console.ReadLine(), out matriz[linha, coluna])) { return null; }
                }
            }

            return matriz;
        }

        static void ApresentarMatriz(double[,] matriz, out double[,] matrizSaida)
        {
            if (matriz == null)
            {
                Console.WriteLine("Você digitou um ou mais caracteres inválidos durante a operação.");
            }
            else
            {
                for (byte linha = 0; linha < matriz.GetLength(0); linha++)
                {
                    for (byte coluna = 0; coluna < matriz.GetLength(1); coluna++)
                    {
                        Console.Write(coluna < matriz.GetLength(1) - 1 ? "[" + matriz[linha, coluna] + "]" :
                           "[" + matriz[linha, coluna] + "]\n");
                    }
                }
            }
            matrizSaida = matriz;
        }

        static double[,] SomarMatrizes(double[,] matrizA, double[,] matrizB)
        {
            if (matrizA == null || matrizB == null) { return null; }
            else if( matrizA.GetLength(0) != matrizB.GetLength(0) || matrizA.GetLength(1) != matrizB.GetLength(1))
            {
                Console.WriteLine("O número de linhas e colunas das matrizes precisam ser os mesmos.");
                return null;
            }

            for (byte linha = 0; linha < matrizA.GetLength(0); linha++)
            {
                for (byte coluna = 0; coluna < matrizA.GetLength(1); coluna++)
                {
                    matrizA[linha, coluna] += matrizB[linha, coluna];
                }
            }
            return matrizA;
        }

        static double[,] SubtrairMatrizes(double[,] matrizA, double[,] matrizB)
        {
            if (matrizA == null || matrizB == null) { return null; }
            else if (matrizA.GetLength(0) != matrizB.GetLength(0) || matrizA.GetLength(1) != matrizB.GetLength(1))
            {
                Console.WriteLine("O número de linhas e colunas das matrizes precisam ser os mesmos.");
                return null;
            }

            for (byte linha = 0; linha < matrizA.GetLength(0); linha++)
            {
                for (byte coluna = 0; coluna < matrizA.GetLength(1); coluna++)
                {
                    matrizA[linha, coluna] -= matrizB[linha, coluna];
                }
            }
            return matrizA;
        }
    }
}
