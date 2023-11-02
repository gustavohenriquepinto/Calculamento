using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasesNumericas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            #region Início
            Console.Clear();
            Console.WriteLine("Bem-vindo ao sistema de cáculos com bases numéricas.");
            Console.WriteLine("Para definir um número numa base, basta digitar 172:8, ou seja, 172 na base 8.");
            #endregion

            num1 = Matematica.DefinirNumero(Console.ReadLine);

     

            //Console.WriteLine("\nDefina a operação que deseja realizar:");
            //Console.WriteLine("# - Obter a representação em outra base.");
            //Console.WriteLine("+ - Somar a outro número.");
            //Console.WriteLine("- - Diminuir por outro número.");
            //Console.WriteLine("* - Multiplicar por outro número.");
            //Console.WriteLine("/ - Dividir por outro número.");

            //switch (operacao = char.Parse(Console.ReadLine()))
            //{
            //    case '#':

            //        break;
            //}
        }

        void AlterarBase()
        {
            Console.Write("\nDefina a nova base: ");
            byte novaBase = byte.Parse(Console.ReadLine());

            
        }
    }
}
