﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Apoio.DefinirMatrizA();
            Apoio.DefinirOperacao();
            Apoio.ApresentarMatrizC();

            Console.WriteLine("Fim");
            Console.ReadKey();

        }
    }
}
