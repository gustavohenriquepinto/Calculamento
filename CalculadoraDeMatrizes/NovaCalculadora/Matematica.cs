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
        public double numeroReal, determinante = 1;

        public void Iniciar()
        {
            Console.Clear();
            Console.WriteLine("============\nCalculadora de Matrizes\n============\n");

            DefinirMatrizA();
        }

        private void DefinirMatrizA()
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

            Operacao();

            #region Confirmação A
            //Console.WriteLine("\nA Matriz A é:");
            //for (int linhas = 0; linhas < linhasA; linhas++)
            //{
            //    for (int colunas = 0; colunas < colunasA; colunas++)
            //    {
            //        Console.Write("[" + matrizA[linhas, colunas] + "]");
            //        if (colunas == (colunasA - 1))
            //        {
            //            Console.WriteLine();
            //        }
            //    }
            //}

            //Console.Write("\nIsso está correto? (\"Sim\" para continuar): ");
            //string matrizACorreta = Console.ReadLine();

            //if (matrizACorreta == "sim" || matrizACorreta == "Sim")
            //{
            //    Operacao();
            //}
            //else
            //{
            //    Reiniciar();
            //}
            #endregion

        }

        private void DefinirMatrizB()
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

            #region Confirmação B
            //Console.WriteLine("\nA Matriz B é:");
            //for (int linhas = 0; linhas < linhasB; linhas++)
            //{
            //    for (int colunas = 0; colunas < colunasB; colunas++)
            //    {
            //        Console.Write("[" + matrizB[linhas, colunas] + "]");
            //        if (colunas == (colunasB - 1))
            //        {
            //            Console.WriteLine();
            //        }
            //    }
            //}

            //Console.Write("\nIsso está correto? (\"Sim\" para continuar): ");
            //string matrizBCorreta = Console.ReadLine();

            //if (matrizBCorreta == "sim" || matrizBCorreta == "Sim")
            //{

            //}
            //else
            //{
            //    Reiniciar();
            //}
            #endregion

        }

        private void DefinirNumeroReal()
        {
            Console.WriteLine("Defina um número real:");
            numeroReal = double.Parse(Console.ReadLine());
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
                    AdicaoMatrizes();
                    break;
                case 2:
                    SubtracaoMatrizes();
                    break;
                case 3:
                    MultiplicacaoMatrizes();
                    break;
                case 5:
                    MultiplicacaoNumeroReal();
                    break;
                case 6:
                    DivisaoNumeroReal();
                    break;
                case 7:
                    MatrizTransposta();
                    break;
                case 8:
                    MatrizInversa();
                    break;
                case 9:
                    Determinante();
                    break;


            } 
        }

        private void ApresentarMatrizC()
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

            Console.WriteLine("\nDeseja realizar mais operações utilizando a matriz resultado? (S/N)");
            string continuar = Console.ReadLine();

            if (continuar == "s" || continuar == "S")
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

        private void Reiniciar() { 

            Console.Write("\nVocê deseja reiniciar? (S/N)");
            string reiniciar = Console.ReadLine();

            if (reiniciar == "s" || reiniciar == "S")
            {
                Iniciar();
            }

        }


        #region Operações

        private void AdicaoMatrizes()
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
        private void SubtracaoMatrizes()
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
        private void MultiplicacaoMatrizes()
        {
            DefinirMatrizB();

            linhasC = linhasA;
            colunasC = colunasB;
            matrizC = new double[linhasC, colunasC];

            if (colunasA != linhasB)
            {
                Console.WriteLine("\nSó é possível realizar essa operação se o número de linhas da segunda matriz e o colunas da primeira for o mesmo.");
                Reiniciar();
            }
            else
            {
                double[] elementosA = new double[colunasA];
                double[] elementosB = new double[linhasB];
                double[] elementosMultiplicados = new double[colunasA];

                double somaElementos = 0;


                for (int linhas = 0; linhas < linhasC; linhas++)
                {
                    for (int colunas = 0; colunas < colunasC; colunas++)
                    {

                        for (int i = 0; i < elementosA.Length; i++)
                        {
                            elementosA[i] = matrizA[linhas, i];
                            elementosB[i] = matrizB[i, colunas];

                            elementosMultiplicados[i] = elementosA[i] * elementosB[i];

                            somaElementos += elementosMultiplicados[i];
                        }

                        matrizC[linhas, colunas] = somaElementos;

                        somaElementos = 0;
                    }
                }
                ApresentarMatrizC();

            }
        }
        private void MultiplicacaoNumeroReal()
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
        private void DivisaoNumeroReal()
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
        private void MatrizTransposta()
        {
            linhasC = colunasA;
            colunasC = linhasA;
            matrizC = new double[linhasC, colunasC];

            for (int linhas = 0; linhas < linhasC; linhas++)
            {
                for (int colunas = 0; colunas < colunasC; colunas++)
                {
                    matrizC[linhas, colunas] = matrizA[colunas, linhas];
                }
            }

            ApresentarMatrizC();
        }
        private void MatrizInversa()
        {
            if (colunasA != linhasA)
            {
                Console.WriteLine("\nSó é possível realizar essa operação se o número de linhas colunas da primeira for o mesmo.");
                Reiniciar();
            }
            else
            {
                linhasC = linhasA;
                colunasC = colunasA;
                matrizC = new double[linhasC, colunasC];

                //Gerando a matriz estendida

                matrizB = new double[linhasA, 2 * colunasA];

                for (int linhas = 0; linhas < linhasA; linhas++)
                {
                    for (int colunas = 0; colunas < colunasA; colunas++)
                    {
                        matrizB[linhas, colunas] = matrizA[linhas, colunas];
                        matrizB[linhas, colunas + colunasA] = linhas == colunas ? 1 : 0;
                    }
                }

                // Aplicando a eliminação de Gaus Jordan

                for(int linhas = 0; linhas < linhasA; linhas++)
                {
                    double referencial = matrizB[linhas, linhas];
                    if (referencial == 0)
                    {
                        Console.WriteLine("\nNão é possível realizar a operação pois o determinante da matriz é 0.");
                        Reiniciar();
                    }

                    for(int colunas = 0; colunas < 2 * colunasA; colunas++)
                    {
                        matrizB[linhas, colunas] /= referencial;
                    }

                    for (int k = 0; k < linhasA; k++)
                    {
                        if (k != linhas)
                        {
                            double fator = matrizB[k, linhas];
                            for (int colunas = 0; colunas < 2 * colunasA; colunas++)
                            {
                                matrizB[k, colunas] -= fator * matrizB[linhas, colunas];
                            }
                        }
                    }
                }

                // Extraindo a parte direita da matriz

                for (int linhas = 0; linhas < linhasC; linhas++)
                {
                    for (int colunas = 0; colunas < colunasC; colunas++)
                    {
                        matrizC[linhas, colunas] = matrizB[linhas, (colunas + colunasA)];
                    }
                }

                ApresentarMatrizC();
            }
        }
        private void Determinante()
        {
            if (colunasA != linhasA)
            {
                Console.WriteLine("\nSó é possível realizar essa operação se o número de linhas colunas da primeira for o mesmo.");
                Reiniciar();
            }
            else
            {
                while(linhasA > 1)
                {
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


                    numeroReal = matrizA[0, 0];
                    determinante *= Math.Pow(numeroReal, linhasA);

                    Console.WriteLine("Determinnte: " + determinante);
                    Console.WriteLine("numero Rel: " + numeroReal);

                    for (int linhas = 0; linhas < linhasA; linhas++)
                    {
                        for (int colunas = 0; colunas < colunasA; colunas++)
                        {
                            matrizA[linhas, colunas] /= numeroReal;
                        }
                    }

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

                    linhasB = (byte)(linhasA - 1);
                    colunasB = (byte)(colunasA - 1);
                    matrizB = new double[linhasB, colunasB];

                    for (int linhas = 0; linhas < linhasB; linhas++)
                    {
                        for (int colunas = 0; colunas < colunasB; colunas++)
                        {
                            matrizB[linhas, colunas] -= (matrizA[(linhas + 1), 0] * matrizA[0, (colunas + 1)]);
                        }
                    }

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

                    linhasA--;
                    colunasA--;
                    matrizA = matrizB;

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
                }

                determinante *= matrizA[0, 0];

                Console.WriteLine("\nO resultado da operação é: " + determinante);
                Reiniciar();

            }
        }

        #endregion
    }

}

