using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasesNumericas
{
    static class Matematica
    {
        static public double DefinirNumero()
        {
            string numtxt = Console.ReadLine();
            if (numtxt.Contains(':'))
            {
                string[] base_e_numero_txt = numtxt.Split(':');

                if(base_e_numero_txt.Length == 2 )
                {
                    byte baseNumerica;

                    if (base_e_numero_txt[0].TryParse())
                    {

                    }
                        
                }
            }

            return ;
        }
    }
}
