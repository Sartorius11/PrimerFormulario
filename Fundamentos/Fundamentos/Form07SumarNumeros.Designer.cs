namespace Fundamentos
{
    partial class Form07SumarNumeros
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.btnSumarNumeros = new System.Windows.Forms.Button();
            this.lblSuma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca números";
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(26, 62);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(338, 35);
            this.txtNumeros.TabIndex = 1;
            // 
            // btnSumarNumeros
            // 
            this.btnSumarNumeros.Location = new System.Drawing.Point(86, 119);
            this.btnSumarNumeros.Name = "btnSumarNumeros";
            this.btnSumarNumeros.Size = new System.Drawing.Size(214, 46);
            this.btnSumarNumeros.TabIndex = 2;
            this.btnSumarNumeros.Text = "Sumar Números";
            this.btnSumarNumeros.UseVisualStyleBackColor = true;
            this.btnSumarNumeros.Click += new System.EventHandler(this.btnSumarNumeros_Click);
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.ForeColor = System.Drawing.Color.Blue;
            this.lblSuma.Location = new System.Drawing.Point(32, 189);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(87, 30);
            this.lblSuma.TabIndex = 3;
            this.lblSuma.Text = "lblSuma";
            // 
            // Form07SumarNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 254);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.btnSumarNumeros);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form07SumarNumeros";
            this.Text = "Form07SumarNumeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNumeros;
        private Button btnSumarNumeros;
        private Label lblSuma;
    }
}