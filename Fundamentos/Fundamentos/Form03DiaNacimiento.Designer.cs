namespace Fundamentos
{
    partial class Form03DiaNacimiento
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
            this.btnCalcularDia = new System.Windows.Forms.Button();
            this.txtAnyo = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcularDia
            // 
            this.btnCalcularDia.Location = new System.Drawing.Point(147, 163);
            this.btnCalcularDia.Name = "btnCalcularDia";
            this.btnCalcularDia.Size = new System.Drawing.Size(216, 44);
            this.btnCalcularDia.TabIndex = 18;
            this.btnCalcularDia.Text = "Calcular día";
            this.btnCalcularDia.UseVisualStyleBackColor = true;
            this.btnCalcularDia.Click += new System.EventHandler(this.btnCalcularDia_Click);
            // 
            // txtAnyo
            // 
            this.txtAnyo.Location = new System.Drawing.Point(256, 108);
            this.txtAnyo.Name = "txtAnyo";
            this.txtAnyo.Size = new System.Drawing.Size(100, 35);
            this.txtAnyo.TabIndex = 17;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(253, 61);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 35);
            this.txtMes.TabIndex = 16;
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(253, 18);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(100, 35);
            this.txtDia.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Año";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Día";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(74, 229);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(126, 30);
            this.lblResultado.TabIndex = 19;
            this.lblResultado.Text = "lblResultado";
            // 
            // Form03DiaNacimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 287);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcularDia);
            this.Controls.Add(this.txtAnyo);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form03DiaNacimiento";
            this.Text = "Form03DiaNacimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalcularDia;
        private TextBox txtAnyo;
        private TextBox txtMes;
        private TextBox txtDia;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblResultado;
    }
}