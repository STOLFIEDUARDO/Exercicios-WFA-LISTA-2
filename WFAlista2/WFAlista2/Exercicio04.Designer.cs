namespace WFAlista2
{
    partial class Exercicio04
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
            this.btApresentar = new System.Windows.Forms.Button();
            this.lbNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtApresentar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btApresentar
            // 
            this.btApresentar.Location = new System.Drawing.Point(61, 179);
            this.btApresentar.Name = "btApresentar";
            this.btApresentar.Size = new System.Drawing.Size(92, 46);
            this.btApresentar.TabIndex = 0;
            this.btApresentar.Text = "Apresentar";
            this.btApresentar.UseVisualStyleBackColor = true;
            this.btApresentar.Click += new System.EventHandler(this.btApresentar_Click);
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(9, 19);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(35, 13);
            this.lbNumero.TabIndex = 1;
            this.lbNumero.Text = "label1";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(92, 12);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // txtApresentar
            // 
            this.txtApresentar.Location = new System.Drawing.Point(12, 53);
            this.txtApresentar.Multiline = true;
            this.txtApresentar.Name = "txtApresentar";
            this.txtApresentar.Size = new System.Drawing.Size(180, 105);
            this.txtApresentar.TabIndex = 3;
            // 
            // Exercicio04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtApresentar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.btApresentar);
            this.Name = "Exercicio04";
            this.Text = "Exercicio04";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btApresentar;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtApresentar;
    }
}