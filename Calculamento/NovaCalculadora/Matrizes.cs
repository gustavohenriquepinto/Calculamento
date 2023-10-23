using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaCalculadora
{
    internal class Matrizes
    {
        //public byte matrizA.GetLength(0), matrizB.GetLength(0), matrizA.GetLength(0), matrizA.GetLength(1), matrizB.GetLength(1), colunasC;
        //public double[,] matrizA, matrizB, matrizResultado;
        //public double numeroReal, determinante;


        static void Main(string[] args)
        {
            Matrizes m = new Matrizes();
            m.Iniciar();
        }

        private void Iniciar()
        {
            Console.Clear();
            Console.WriteLine("============\nCalculadora de Matrizes\n============\n");

            Operacao();
        }

        private double[,] DefinirMatrizA()
        {
            Console.WriteLine("Defina o número de linhas e colunas da matriz A:");

            Console.Write("Linhas:");
            byte linhasA = byte.Parse(Console.ReadLine());
            Console.Write("Colunas:");
            byte colunasA = byte.Parse(Console.ReadLine());

            double[,] matrizA = new double[linhasA, colunasA];

            for (int linhas = 0; linhas < matrizA.GetLength(0); linhas++)
            {
                for (int colunas = 0; colunas < matrizA.GetLength(1); colunas++)
                {
                    Console.Write($"Digite o valor de [{linhas + 1},{colunas + 1}]: ");
                    matrizA[linhas, colunas] = double.Parse(Console.ReadLine());
                }
            }

            return matrizA;
        }

        private double[,] DefinirMatrizB()
        {
            Console.WriteLine("Defina o número de linhas e colunas da matriz B:");

            Console.Write("Linhas:");
            byte linhasB = byte.Parse(Console.ReadLine());
            Console.Write("Colunas:");
            byte colunasB = byte.Parse(Console.ReadLine());

            double[,] matrizB = new double[linhasB, colunasB];

            for (int linhas = 0; linhas < matrizB.GetLength(0); linhas++)
            {
                for (int colunas = 0; colunas < matrizB.GetLength(1); colunas++)
                {
                    Console.Write($"Digite o valor de [{linhas + 1},{colunas + 1}]: ");
                    matrizB[linhas, colunas] = double.Parse(Console.ReadLine());
                }
            }

            return matrizB;
        }

        private double DefinirNumeroReal()
        {
            Console.WriteLine("Defina um número real:");
            double numeroReal = double.Parse(Console.ReadLine());

            return numeroReal;
        }

        private void Operacao()
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
                    AdicaoMatrizes(DefinirMatrizA(), DefinirMatrizB());
                    break;
                case 2:
                    SubtracaoMatrizes(DefinirMatrizA(), DefinirMatrizB());
                    break;
                case 3:
                    MultiplicacaoMatrizes(DefinirMatrizA(), DefinirMatrizB());
                    break;
                case 5:
                    MultiplicacaoNumeroReal(DefinirMatrizA(), DefinirNumeroReal());
                    break;
                case 6:
                    DivisaoNumeroReal(DefinirMatrizA(), DefinirNumeroReal());
                    break;
                case 7:
                    MatrizTransposta(DefinirMatrizA());
                    break;
                case 8:
                    MatrizInversa(DefinirMatrizA());
                    break;
                case 9:
                    Determinante(DefinirMatrizA());
                    break;


            }
            ApresentarResultado();
        }

        private void ApresentarResultado()
        {

            Console.WriteLine("\nO resultado é:");
            for (int linhas = 0; linhas < matrizA.GetLength(0); linhas++)
            {
                for (int colunas = 0; colunas < colunasC; colunas++)
                {
                    Console.Write("[" + matrizResultado[linhas, colunas] + "]");
                    if (colunas == colunasC - 1)
                    {
                        Console.Write("\n");
                    }
                }
            }

            Console.WriteLine("\nDeseja realizar mais operações utilizando a matriz resultado? (S/N)");
            string continuar = Console.ReadLine();

            if (continuar == "s" || continuar == "S")
            {
                matrizA.GetLength(0) = matrizA.GetLength(0);
                matrizA.GetLength(1) = colunasC;
                matrizA = matrizResultado;

                Operacao();
            }
            else
            {
                Reiniciar();
            }
        }

        private void Reiniciar()
        {

            Console.Write("\nVocê deseja reiniciar? (S/N)");
            string reiniciar = Console.ReadLine();

            if (reiniciar == "s" || reiniciar == "S")
            {
                Iniciar();
            }

        }


        #region Operações

        private double[,] AdicaoMatrizes(double[,] matrizA, double[,] matrizB)
        {
            if (matrizA.GetLength(0) != matrizB.GetLength(0) || matrizA.GetLength(1) != matrizB.GetLength(1))
            {
                Console.WriteLine("\nSó é possível realizar essa operação se o número de linhas e colunas for o mesmo.");
                return null;
            }
            else
            { 
                for (int linhas = 0; linhas < matrizA.GetLength(0); linhas++)
                {
                    for (int colunas = 0; colunas < matrizA.GetLength(1); colunas++)
                    {
                        matrizA[linhas, colunas] += matrizB[linhas, colunas];
                    }
                }

                return matrizA;
            }
        }
        private double[,] SubtracaoMatrizes(double[,] matrizA, double[,] matrizB)
        {
            if (matrizA.GetLength(0) != matrizB.GetLength(0) || matrizA.GetLength(1) != matrizB.GetLength(1))
            {
                Console.WriteLine("\nSó é possível realizar essa operação se o número de linhas e colunas for o mesmo.");
                return null;
            }
            else
            {
                for (int linhas = 0; linhas < matrizA.GetLength(0); linhas++)
                {
                    for (int colunas = 0; colunas < matrizA.GetLength(1); colunas++)
                    {
                        matrizA[linhas, colunas] -= matrizB[linhas, colunas];
                    }
                }

                return matrizA;
            }
        }
        private double[,] MultiplicacaoMatrizes(double[,] matrizA, double[,] matrizB)
        {
            if (matrizA.GetLength(1) != matrizB.GetLength(0))
            {
                Console.WriteLine("\nSó é possível realizar essa operação se o número de linhas da segunda matriz e o colunas da primeira for o mesmo.");
                return null;
            }
            else
            {
                double[,] matrizResultado = new double[matrizA.GetLength(0), matrizB.GetLength(1)];
                double somaElementos = 0;

                for (int linhas = 0; linhas < matrizA.GetLength(0); linhas++)
                {
                    for (int colunas = 0; colunas < matrizA.GetLength(0); colunas++)
                    {
                        for (int i = 0; i < matrizA.GetLength(0); i++)
                        {
                            somaElementos += matrizA[linhas, i] * matrizB[i, colunas];
                        }

                        matrizResultado[linhas, colunas] = somaElementos;
                        somaElementos = 0;
                    }
                }

                return matrizResultado;
            }
        }
        private double[,] MultiplicacaoNumeroReal(double[,] matrizA, double numeroReal)
        {
            for (int linhas = 0; linhas < matrizA.GetLength(0); linhas++)
            {
                for (int colunas = 0; colunas < matrizA.GetLength(1); colunas++)
                {
                    matrizA[linhas, colunas] *= numeroReal;
                }
            }
            return matrizA;
        }
        private double[,] DivisaoNumeroReal(double[,] matrizA, double numeroReal)
        {
            for (int linhas = 0; linhas < matrizA.GetLength(0); linhas++)
            {
                for (int colunas = 0; colunas < matrizA.GetLength(1); colunas++)
                {
                    matrizA[linhas, colunas] /= numeroReal;
                }
            }
            return matrizA;
        }
        private double[,] MatrizTransposta(double[,] matrizA)
        {
            double[,] matrizResultado = new double[matrizA.GetLength(1), matrizA.GetLength(0)];

            for (int linhas = 0; linhas < matrizA.GetLength(0); linhas++)
            {
                for (int colunas = 0; colunas < matrizResultado.GetLength(1); colunas++)
                {
                    matrizResultado[linhas, colunas] = matrizA[colunas, linhas];
                }
            }

            return matrizResultado;
        }
        private double[,] MatrizInversa(double[,] matrizA)
        {
            if (matrizA.GetLength(1) != matrizA.GetLength(0))
            {
                Console.WriteLine("\nSó é possível realizar essa operação se o número de linhas colunas da primeira for o mesmo.");
                return null;
            }
            else
            {
                double[,] matrizIdentidade = new double[matrizA.GetLength(0), matrizA.GetLength(1)];

                //Gerando a matriz estendida

                double[,] matrizEstendida = new double[matrizA.GetLength(0), 2 * matrizA.GetLength(1)];

                for (int linhas = 0; linhas < matrizA.GetLength(0); linhas++)
                {
                    for (int colunas = 0; colunas < matrizA.GetLength(1); colunas++)
                    {
                        matrizEstendida[linhas, colunas] = matrizA[linhas, colunas];
                        matrizEstendida[linhas, colunas + matrizA.GetLength(1)] = linhas == colunas ? 1 : 0;
                    }
                }

                // Aplicando a eliminação de Gaus Jordan

                for (int linhas = 0; linhas < matrizA.GetLength(0); linhas++)
                {
                    double referencial = matrizEstendida[linhas, linhas];
                    if (referencial == 0)
                    {
                        Console.WriteLine("\nNão é possível realizar a operação pois o determinante da matriz é 0.");
                        Reiniciar();
                    }

                    for (int colunas = 0; colunas < 2 * matrizA.GetLength(1); colunas++)
                    {
                        matrizEstendida[linhas, colunas] /= referencial;
                    }

                    for (int k = 0; k < matrizA.GetLength(0); k++)
                    {
                        if (k != linhas)
                        {
                            double fator = matrizEstendida[k, linhas];
                            for (int colunas = 0; colunas < 2 * matrizA.GetLength(1); colunas++)
                            {
                                matrizEstendida[k, colunas] -= fator * matrizEstendida[linhas, colunas];
                            }
                        }
                    }
                }

                // Extraindo a parte direita da matriz

                for (int linhas = 0; linhas < matrizA.GetLength(0); linhas++)
                {
                    for (int colunas = 0; colunas < matrizA.GetLength(1); colunas++)
                    {
                        matrizIdentidade[linhas, colunas] = matrizEstendida[linhas, (colunas + matrizA.GetLength(1))];
                    }
                }

                return matrizIdentidade;
            }
        }
        private double Determinante(double[,] matrizA)
        {
            return 0;
            //if (matrizA.GetLength(1) != matrizA.GetLength(0))
            //{
            //    Console.WriteLine("\nSó é possível realizar essa operação se o número de linhas colunas da primeira for o mesmo.");
            //    Reiniciar();
            //}
            //else
            //{
            //    while (matrizA.GetLength(0) > 1)
            //    {
            //        for (int linhas = 0; linhas < matrizA.GetLength(0); linhas++)
            //        {
            //            for (int colunas = 0; colunas < matrizA.GetLength(1); colunas++)
            //            {
            //                Console.Write("[" + matrizA[linhas, colunas] + "]");
            //                if (colunas == (matrizA.GetLength(1) - 1))
            //                {
            //                    Console.WriteLine();
            //                }
            //            }
            //        }


            //        numeroReal = matrizA[0, 0];
            //        determinante *= Math.Pow(numeroReal, matrizA.GetLength(0));

            //        Console.WriteLine("Determinnte: " + determinante);
            //        Console.WriteLine("numero Rel: " + numeroReal);

            //        for (int linhas = 0; linhas < matrizA.GetLength(0); linhas++)
            //        {
            //            for (int colunas = 0; colunas < matrizA.GetLength(1); colunas++)
            //            {
            //                matrizA[linhas, colunas] /= numeroReal;
            //            }
            //        }

            //        for (int linhas = 0; linhas < matrizA.GetLength(0); linhas++)
            //        {
            //            for (int colunas = 0; colunas < matrizA.GetLength(1); colunas++)
            //            {
            //                Console.Write("[" + matrizA[linhas, colunas] + "]");
            //                if (colunas == (matrizA.GetLength(1) - 1))
            //                {
            //                    Console.WriteLine();
            //                }
            //            }
            //        }

            //        matrizB.GetLength(0) = (byte)(matrizA.GetLength(0) - 1);
            //        matrizB.GetLength(1) = (byte)(matrizA.GetLength(1) - 1);
            //        matrizB = new double[matrizB.GetLength(0), matrizB.GetLength(1)];

            //        for (int linhas = 0; linhas < matrizB.GetLength(0); linhas++)
            //        {
            //            for (int colunas = 0; colunas < matrizB.GetLength(1); colunas++)
            //            {
            //                matrizB[linhas, colunas] -= (matrizA[(linhas + 1), 0] * matrizA[0, (colunas + 1)]);
            //            }
            //        }

            //        for (int linhas = 0; linhas < matrizB.GetLength(0); linhas++)
            //        {
            //            for (int colunas = 0; colunas < matrizB.GetLength(1); colunas++)
            //            {
            //                Console.Write("[" + matrizB[linhas, colunas] + "]");
            //                if (colunas == (matrizB.GetLength(1) - 1))
            //                {
            //                    Console.WriteLine();
            //                }
            //            }
            //        }

            //        matrizA.GetLength(0)--;
            //        matrizA.GetLength(1)--;
            //        matrizA = matrizB;

            //        for (int linhas = 0; linhas < matrizA.GetLength(0); linhas++)
            //        {
            //            for (int colunas = 0; colunas < matrizA.GetLength(1); colunas++)
            //            {
            //                Console.Write("[" + matrizA[linhas, colunas] + "]");
            //                if (colunas == (matrizA.GetLength(1) - 1))
            //                {
            //                    Console.WriteLine();
            //                }
            //            }
            //        }
            //    }

            //    determinante *= matrizA[0, 0];

            //    Console.WriteLine("\nO resultado da operação é: " + determinante);
            //    Reiniciar();

            //}
        }

        #endregion
    }
}
