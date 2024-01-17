using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class formEntrar : Form
    {
        public formEntrar()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            if (labelUsuario.Text == "Gustavo" && labelSenha.Text == "123")
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto(s).");
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
