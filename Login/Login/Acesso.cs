using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class Acesso
    {
        string senha = "13/05/1888";
        public bool CompararSenha(string senha)
        {
            return senha == this.senha;
        }

        public byte ProximaTentaiva(ref byte tentativa)
        {
            return tentativa++;
        }
    }
}
