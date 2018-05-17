using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAlista2
{
    public partial class Exercicio02 : Form
    {
        public Exercicio02()
        {
            InitializeComponent();
        }

        private void btApresentar_Click(object sender, EventArgs e)
        {
            int numero = 0;

            numero = Convert.ToInt32(txtNumero.Text);

            if (numero == 0)
            {
                txtApresentar.Text = "Não é Negativo.";
            }
            else if (numero > 0)
            {
                txtApresentar.Text = "Não é Negativo.";
            }
            else
            {
                txtApresentar.Text = "É Negativo.";
            }
        
        }
    }
}
