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
    public partial class Exercicio03 : Form
    {
        public Exercicio03()
        {
            InitializeComponent();
        }
        double numero1 = 0, numero2 = 0;
        string Resultado = "";

        private void btApresentar_Click(object sender, EventArgs e)
        {
            
      
            numero1 = Convert.ToDouble(txtNumero1.Text);         
            numero2 = Convert.ToDouble(txtNumero2.Text);
     

         if (rbSomar.Checked)
         {
             Somar();
         }
         else if (rbSubtrair.Checked)
         {
             Subtrair();
         }
         else if (rbMultiplicar.Checked)
         {
             Multiplicar();
         }
         else if (rbDividir.Checked)
         {
             Dividir();
         }
        

         txtApresentar.Text = Resultado;
     }

     private void Somar()
     {
         double soma = numero1 + numero2;
         Resultado = Resultado = String.Format("{0} + {1} = {2:n}", numero1, numero2, soma);
     }

     private void Subtrair()
     {
         double subtracao = numero1 - numero2;
         Resultado = Resultado = String.Format("{0} - {1} = {2:n}", numero1, numero2, subtracao);
     }

     private void Multiplicar()
     {
         double multiplicacao = numero1 * numero2;
         Resultado = Resultado = String.Format("{0} x {1} = {2:n}", numero1, numero2, multiplicacao);
     }

     private void Dividir()
     {
         double divisao = (numero1 / numero2);
         Resultado = String.Format("{0} ÷ {1} = {2:n}", numero1, numero2,divisao);
     }
   }
 }

