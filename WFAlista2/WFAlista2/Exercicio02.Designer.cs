namespace WFAlista2
{
    partial class Exercicio02
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
            this.lbNumer = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtApresentar = new System.Windows.Forms.TextBox();
            this.btApresentar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNumer
            // 
            this.lbNumer.AutoSize = true;
            this.lbNumer.Location = new System.Drawing.Point(12, 15);
            this.lbNumer.Name = "lbNumer";
            this.lbNumer.Size = new System.Drawing.Size(44, 13);
            this.lbNumer.TabIndex = 0;
            this.lbNumer.Text = "Numero";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(62, 12);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // txtApresentar
            // 
            this.txtApresentar.Location = new System.Drawing.Point(39, 76);
            this.txtApresentar.Multiline = true;
            this.txtApresentar.Name = "txtApresentar";
            this.txtApresentar.Size = new System.Drawing.Size(166, 89);
            this.txtApresentar.TabIndex = 2;
            // 
            // btApresentar
            // 
            this.btApresentar.Location = new System.Drawing.Point(87, 187);
            this.btApresentar.Name = "btApresentar";
            this.btApresentar.Size = new System.Drawing.Size(75, 52);
            this.btApresentar.TabIndex = 3;
            this.btApresentar.Text = "Apresentar";
            this.btApresentar.UseVisualStyleBackColor = true;
            this.btApresentar.Click += new System.EventHandler(this.btApresentar_Click);
            // 
            // Exercicio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btApresentar);
            this.Controls.Add(this.txtApresentar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lbNumer);
            this.Name = "Exercicio02";
            this.Text = "Exercicio02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumer;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtApresentar;
        private System.Windows.Forms.Button btApresentar;
    }
}