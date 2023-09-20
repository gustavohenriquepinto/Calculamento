using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NovaCalculadora
{
    class Matematica
    {
        public byte linhasA, linhasB, linhasC, colunasA, colunasB, colunasC;
        public double[,] matrizA, matrizB, matrizC;
        public double numeroReal;

        public void Iniciar()
        {
            Console.Clear();
            Console.WriteLine("============\nCalculadora de Matrizes\n============\n");

            DefinirMatrizA();
        }

        public void DefinirMatrizA()
        {
            Console.WriteLine("Defina o número de linhas e colunas da matriz A:");

            Console.Write("Linhas:");
            linhasA = byte.Parse(Console.ReadLine());
            Console.Write("Colunas:");
            colunasA = byte.Parse(Console.ReadLine());

            matrizA = new double[linhasA, colunasA];


            for (int linhas = 0; linhas < linhasA; linhas++)
            {
                for (int colunas = 0; colunas < colunasA; colunas++)
                {
                    Console.Write("Digite o valor de [" + (linhas+1) + "," + (colunas+1) + "]: ");
                    matrizA[linhas, colunas] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nA Matriz A é:");
            for (int linhas = 0; linhas < linhasA; linhas++)
            {
                for (int colunas = 0; colunas < colunasA; colunas++)
                {
                    Console.Write("[" + matrizA[linhas, colunas] + "]");
                    if (colunas == (colunasA - 1))
                    {
                        Console.WriteLine();
                    }
                }
            }

            Console.Write("\nIsso está correto? (\"Sim\" para continuar): ");
            string matrizACorreta = Console.ReadLine();

            if (matrizACorreta == "sim" || matrizACorreta == "Sim")
            {
                Operacao();
            }
            else
            {
                Reiniciar();
            }

        }

        public void DefinirMatrizB()
        {
           
            Console.WriteLine("\nDefina o número de linhas e colunas da matriz B:");

            Console.Write("Linhas:");
            linhasB = byte.Parse(Console.ReadLine());
            Console.Write("Colunas:");
            colunasB = byte.Parse(Console.ReadLine());

            matrizB = new double[linhasB, colunasB];

            for (int linhas = 0; linhas < linhasB; linhas++)
            {
                for (int colunas = 0; colunas < colunasB; colunas++)
                {
                    Console.Write("Digite o valor de [" + (linhas+1) + "," + (colunas+1) + "]: ");
                    matrizB[linhas, colunas] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nA Matriz B é:");
            for (int linhas = 0; linhas < linhasB; linhas++)
            {
                for (int colunas = 0; colunas < colunasB; colunas++)
                {
                    Console.Write("[" + matrizB[linhas, colunas] + "]");
                    if (colunas == (colunasB - 1))
                    {
                        Console.WriteLine();
                    }
                }
            }

            Console.Write("\nIsso está correto? (\"Sim\" para continuar): ");
            string matrizBCorreta = Console.ReadLine();

            if (matrizBCorreta == "sim" || matrizBCorreta == "Sim")
            {
                
            }
            else
            {
                Reiniciar();
            }

        }

        public void DefinirNumeroReal()
        {
            Console.WriteLine("Defina um número real:");
            numeroReal = double.Parse(Console.ReadLine());
        }

        public void Operacao()
        {
            Console.WriteLine("\nEscolha entre uma das operações abaixo:\n");
            Console.WriteLine("1- Adição de Matrizes");
            Console.WriteLine("2- Subtração de Matrizes");
            Console.WriteLine("3- Multiplicação de Matrizes");
            Console.WriteLine("4- Divisão de Matrizes");
            Console.WriteLine("5- Multiplicação por Número Real");
            Console.WriteLine("6- Divisão por Número Real");
            Console.WriteLine("7- Matriz Transposta");
            Console.WriteLine("8- Matriz Inversa");
            Console.WriteLine("9- Determinante");

            byte operacao = byte.Parse(Console.ReadLine());

            switch (operacao)
            {
                default:
                    Console.WriteLine("\nEssa operação não está disponível");
                    Reiniciar();
                    break;

                case 1:
                    AdicaoMatrizes();
                    break;
                case 2:
                    SubtracaoMatrizes();
                    break;
                case 5:
                    MultiplicacaoNumeroReal();
                    break;
                case 6:
                    DivisaoNumeroReal();
                    break;

            } 
        }

        public void ApresentarMatrizC()
        {
            Console.WriteLine("\nO resultado é:");
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

            Console.WriteLine("\nDeseja realizar mais operações utilizando a matriz resultado? (\"Sim\" para continuar)");
            string continuar = Console.ReadLine();

            if (continuar == "sim" || continuar == "Sim")
            {
                linhasA = linhasC;
                colunasA = colunasC;
                matrizA = matrizC;

                Operacao();
            }
            else
            {
                Reiniciar();
            }
        }

        public void Reiniciar() { 

            Console.Write("\nVocê deseja reiniciar? (\"Sim\" para reiniciar)");
            string reiniciar = Console.ReadLine();

            if (reiniciar == "sim" || reiniciar == "Sim")
            {
                Iniciar();
            }

        }


        #region Operações

        public void AdicaoMatrizes()
        {
            DefinirMatrizB();

            linhasC = linhasA;
            colunasC = colunasA;
            matrizC = new double[linhasC, colunasC];


            if (linhasA != linhasB || colunasA != colunasB)
            {
                Console.WriteLine("\nSó é possível realizar essa operação se o número de linhas e colunas for o mesmo.");
                Reiniciar();
            }
            else
            {
                for (int linhas = 0; linhas < linhasA; linhas++)
                {
                    for (int colunas = 0; colunas < colunasA; colunas++)
                    {
                        matrizC[linhas, colunas] = matrizA[linhas, colunas] + matrizB[linhas, colunas];
                    }
                }
                ApresentarMatrizC();
            }
        }

        public void SubtracaoMatrizes()
        {
            DefinirMatrizB();

            linhasC = linhasA;
            colunasC = colunasA;
            matrizC = new double[linhasC, colunasC];


            if (linhasA != linhasB || colunasA != colunasB)
            {
                Console.WriteLine("\nSó é possível realizar essa operação se o número de linhas e colunas for o mesmo.");
                Reiniciar();
            }
            else
            {
                for (int linhas = 0; linhas < linhasA; linhas++)
                {
                    for (int colunas = 0; colunas < colunasA; colunas++)
                    {
                        matrizC[linhas, colunas] = matrizA[linhas, colunas] - matrizB[linhas, colunas];
                    }
                }
                ApresentarMatrizC();
            }
        }

        public void MultiplicacaoNumeroReal()
        {
            DefinirNumeroReal();

            linhasC = linhasA;
            colunasC = colunasA;
            matrizC = new double[linhasC, colunasC];

            for (int linhas = 0; linhas < linhasA; linhas++)
            {
                for (int colunas = 0; colunas < colunasA; colunas++)
                {
                    matrizC[linhas, colunas] = matrizA[linhas, colunas] * numeroReal ;
                }
            }
                ApresentarMatrizC();

        }
        public void DivisaoNumeroReal()
        {
            DefinirNumeroReal();

            linhasC = linhasA;
            colunasC = colunasA;
            matrizC = new double[linhasC, colunasC];

            for (int linhas = 0; linhas < linhasA; linhas++)
            {
                for (int colunas = 0; colunas < colunasA; colunas++)
                {
                    matrizC[linhas, colunas] = matrizA[linhas, colunas] / numeroReal;
                }
            }
            ApresentarMatrizC();

        }

        #endregion
    }

}

