using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inicio:
            Console.Clear();
            Console.WriteLine("==============\nCALCULADORA\n==============");

            #region Entrada

            Console.Write("Digite o primeiro valor: ");
            decimal n1 = decimal.Parse(Console.ReadLine());

            Retornar:

            Console.WriteLine("\nQual das operações a seguir você deseja realizar?\n'+'- Adição\n'-'- Subtração\n'*'- Multiplicação\n'/'- Divisão\n'%'- Resto da Divisão\n'&'- Exponenciação");
            char operacao= char.Parse(Console.ReadLine());

            Console.Write("\nDigite o segundo valor: ");
            decimal n2 = decimal.Parse(Console.ReadLine());

            #endregion

            #region Processamento
            decimal res = 0;

            switch(operacao){
                case '+': res = n1 + n2; break;
                case '-': res = n1 - n2; break;
                case '*': res = n1 * n2; break;
                case '/': res = n1 / n2; break;
                case '%': res = n1 % n2; break;
                case '&': res = (decimal)Math.Pow((double)n1, (double)n2); break;
                default: Console.WriteLine("\nA operação é inválida"); goto Continuar;
            }

            #endregion

            #region Saída

            Console.WriteLine("\nO resultado da operação é: " + res);

        #endregion

            #region Encerramento

            Continuar:

            Console.Write("\nDeseja continuar calculando utilizando o resultado como parte da operação? (S/N): ");
            char continuar = char.Parse(Console.ReadLine());

            if (continuar == 's' || continuar == 'S')
            {
                n1 = res;
                goto Retornar;
            }
            else
            {
                Console.Write("\nDeseja recomeçar? (S/N): ");
                char inicio = char.Parse(Console.ReadLine());

                if (inicio == 's' || inicio == 'S')
                {
                    goto Inicio;
                }
            }
            #endregion
        }
    }
}
