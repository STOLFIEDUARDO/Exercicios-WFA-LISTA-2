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
    public partial class Exercicio05 : Form
    {
        public Exercicio05()
        {
            InitializeComponent();
        }

      int Numero = 0;
        string Resultado = "";

        private void btApresentar_Click(object sender, EventArgs e)
        {
             
           
                Numero = Convert.ToInt32(txtNumero.Text);
           
            if (Numero == 0)
            {
                Resultado = "neutro";
            }
            else if (Numero % 2 == 0)
            {
                Resultado = "Não é Impar";
            }
            else 
            {
                Resultado = "é impar";
            }
            
            txtApresentar.Text = String.Format("O Número {0} = {1}.", Numero, Resultado);
        }
 }
}

