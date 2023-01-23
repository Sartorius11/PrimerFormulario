namespace PrimerFormulario
{
    partial class Ejecicio01Casa
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
            this.btnSumarNumeros = new System.Windows.Forms.Button();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSumarNumeros
            // 
            this.btnSumarNumeros.Location = new System.Drawing.Point(112, 120);
            this.btnSumarNumeros.Name = "btnSumarNumeros";
            this.btnSumarNumeros.Size = new System.Drawing.Size(78, 23);
            this.btnSumarNumeros.TabIndex = 0;
            this.btnSumarNumeros.Text = "Sumar Numeros";
            this.btnSumarNumeros.UseVisualStyleBackColor = true;
            this.btnSumarNumeros.Click += new System.EventHandler(this.btnSumarNumeros_Click);
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(51, 39);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(50, 13);
            this.lblNumero1.TabIndex = 1;
            this.lblNumero1.Text = "Numero1";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(51, 74);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(50, 13);
            this.lblNumero2.TabIndex = 2;
            this.lblNumero2.Text = "Numero2";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(112, 39);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(103, 20);
            this.txtNum1.TabIndex = 3;
         
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(112, 74);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(103, 20);
            this.txtNum2.TabIndex = 4;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(51, 175);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(23, 13);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "lbl3";
            // 
            // Ejecicio01Casa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 210);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Controls.Add(this.btnSumarNumeros);
            this.Name = "Ejecicio01Casa";
            this.Text = "Ejecicio01Casa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSumarNumeros;
        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lbl3;
    }
}