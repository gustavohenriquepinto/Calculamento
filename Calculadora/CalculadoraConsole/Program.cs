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
            #region Entrada

            Console.WriteLine("Digite o primeiro valor:");
            decimal n1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Qual das operações a seguir você deseja realizar?\n1- Adição\n2- Subtração\n3- Multiplicação\n4- Divisão\n5- Resto da Divisão\n6- Exponenciação");
            byte operacao= Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            decimal n2 = Convert.ToDecimal(Console.ReadLine());

            #endregion

            #region Processamento
            decimal res = 0;

            switch(operacao){
                case 1: res = n1 + n2; break;
                case 2: res = n1 - n2; break;
                case 3: res = n1 * n2; break;
                case 4: res = n1 / n2; break;
                case 5: res = n1 % n2; break;
                case 6: res = (decimal)Math.Pow((double)n1, (double)n2); break;
                default: Console.WriteLine("Os valores inseridos são inválidos"); break;
            }

            #endregion

            #region Saída

            Console.WriteLine(res);

            #endregion
        }
    }
}
