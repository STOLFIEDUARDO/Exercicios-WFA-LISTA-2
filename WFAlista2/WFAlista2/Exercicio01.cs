﻿using System;
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
    public partial class Exercicio01 : Form
    {
        public Exercicio01()
        {
            InitializeComponent();
        }

        private void btApresentar_Click(object sender, EventArgs e)
        {
             int numero = 0;

                numero = Convert.ToInt32(txtNumero.Text);
          
            if (numero == 0)
            {
                txtApresentar.Text = "É Positivo.";
            }
            else if (numero > 0)
            {
                txtApresentar.Text = "É Positivo.";
            }
            else
            {
                txtApresentar.Text = "Não é Positivo.";
            }
        



        }
       }
    }

