namespace WFAlista2
{
    partial class Exercicio03
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbSomar = new System.Windows.Forms.RadioButton();
            this.rbSubtrair = new System.Windows.Forms.RadioButton();
            this.rbMultiplicar = new System.Windows.Forms.RadioButton();
            this.rbDividir = new System.Windows.Forms.RadioButton();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.lbNumero1 = new System.Windows.Forms.Label();
            this.lbNumero2 = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtApresentar = new System.Windows.Forms.TextBox();
            this.btApresentar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbSomar
            // 
            this.rbSomar.AutoSize = true;
            this.rbSomar.Location = new System.Drawing.Point(12, 174);
            this.rbSomar.Name = "rbSomar";
            this.rbSomar.Size = new System.Drawing.Size(55, 17);
            this.rbSomar.TabIndex = 0;
            this.rbSomar.TabStop = true;
            this.rbSomar.Text = "Somar";
            this.rbSomar.UseVisualStyleBackColor = true;
            // 
            // rbSubtrair
            // 
            this.rbSubtrair.AutoSize = true;
            this.rbSubtrair.Location = new System.Drawing.Point(73, 174);
            this.rbSubtrair.Name = "rbSubtrair";
            this.rbSubtrair.Size = new System.Drawing.Size(61, 17);
            this.rbSubtrair.TabIndex = 1;
            this.rbSubtrair.TabStop = true;
            this.rbSubtrair.Text = "Subtrair";
            this.rbSubtrair.UseVisualStyleBackColor = true;
            // 
            // rbMultiplicar
            // 
            this.rbMultiplicar.AutoSize = true;
            this.rbMultiplicar.Location = new System.Drawing.Point(140, 174);
            this.rbMultiplicar.Name = "rbMultiplicar";
            this.rbMultiplicar.Size = new System.Drawing.Size(72, 17);
            this.rbMultiplicar.TabIndex = 2;
            this.rbMultiplicar.TabStop = true;
            this.rbMultiplicar.Text = "Multiplicar";
            this.rbMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rbDividir
            // 
            this.rbDividir.AutoSize = true;
            this.rbDividir.Location = new System.Drawing.Point(218, 174);
            this.rbDividir.Name = "rbDividir";
            this.rbDividir.Size = new System.Drawing.Size(54, 17);
            this.rbDividir.TabIndex = 3;
            this.rbDividir.TabStop = true;
            this.rbDividir.Text = "Dividir";
            this.rbDividir.UseVisualStyleBackColor = true;
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(73, 38);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 4;
            // 
            // lbNumero1
            // 
            this.lbNumero1.AutoSize = true;
            this.lbNumero1.Location = new System.Drawing.Point(12, 45);
            this.lbNumero1.Name = "lbNumero1";
            this.lbNumero1.Size = new System.Drawing.Size(50, 13);
            this.lbNumero1.TabIndex = 5;
            this.lbNumero1.Text = "Numero1";
            // 
            // lbNumero2
            // 
            this.lbNumero2.AutoSize = true;
            this.lbNumero2.Location = new System.Drawing.Point(12, 73);
            this.lbNumero2.Name = "lbNumero2";
            this.lbNumero2.Size = new System.Drawing.Size(50, 13);
            this.lbNumero2.TabIndex = 6;
            this.lbNumero2.Text = "Numero2";
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(73, 73);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2.TabIndex = 7;
            // 
            // txtApresentar
            // 
            this.txtApresentar.Location = new System.Drawing.Point(15, 211);
            this.txtApresentar.Multiline = true;
            this.txtApresentar.Name = "txtApresentar";
            this.txtApresentar.Size = new System.Drawing.Size(257, 123);
            this.txtApresentar.TabIndex = 8;
            // 
            // btApresentar
            // 
            this.btApresentar.Location = new System.Drawing.Point(73, 123);
            this.btApresentar.Name = "btApresentar";
            this.btApresentar.Size = new System.Drawing.Size(100, 32);
            this.btApresentar.TabIndex = 9;
            this.btApresentar.Text = "Apresentar";
            this.btApresentar.UseVisualStyleBackColor = true;
            this.btApresentar.Click += new System.EventHandler(this.btApresentar_Click);
            // 
            // Exercicio03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 365);
            this.Controls.Add(this.btApresentar);
            this.Controls.Add(this.txtApresentar);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.lbNumero2);
            this.Controls.Add(this.lbNumero1);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.rbDividir);
            this.Controls.Add(this.rbMultiplicar);
            this.Controls.Add(this.rbSubtrair);
            this.Controls.Add(this.rbSomar);
            this.Name = "Exercicio03";
            this.Text = "Exercicio03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSomar;
        private System.Windows.Forms.RadioButton rbSubtrair;
        private System.Windows.Forms.RadioButton rbMultiplicar;
        private System.Windows.Forms.RadioButton rbDividir;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Label lbNumero1;
        private System.Windows.Forms.Label lbNumero2;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtApresentar;
        private System.Windows.Forms.Button btApresentar;
    }
}