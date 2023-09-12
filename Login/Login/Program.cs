using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acesso a = new Acesso();

            byte tentativa = 1; 

            Console.Clear();
            Console.WriteLine("################\nAcesso ao Sistema\n################");

            Console.Write("\nPara acessar o sistema, você deve acertar qual é a senha. ");
            Console.WriteLine("A cada vez que você errar a senha, novas dicas serão disponibilizadas.");

            Console.Write("\nTentativa # " + tentativa + ":");
            string resultado = a.CompararSenha(Console.ReadLine()) ? "Parabéns, você acertou a senha!" : "Você errou, tente novamente";
            Console.WriteLine(resultado);
            a.ProximaTentaiva(ref tentativa);

        }
    }
}
