namespace Fundamentos
{
    partial class Form12Metodos
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnDobleValor = new System.Windows.Forms.Button();
            this.btnDobleReferencia = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnObjetoReferencia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoloNumeros = new System.Windows.Forms.TextBox();
            this.txtSoloLetras = new System.Windows.Forms.TextBox();
            this.lblMouse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(157, 21);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 35);
            this.txtNumero.TabIndex = 1;
            // 
            // btnDobleValor
            // 
            this.btnDobleValor.Location = new System.Drawing.Point(48, 88);
            this.btnDobleValor.Name = "btnDobleValor";
            this.btnDobleValor.Size = new System.Drawing.Size(188, 45);
            this.btnDobleValor.TabIndex = 2;
            this.btnDobleValor.Text = "Doble() Valor";
            this.btnDobleValor.UseVisualStyleBackColor = true;
            this.btnDobleValor.Click += new System.EventHandler(this.btnDobleValor_Click);
            // 
            // btnDobleReferencia
            // 
            this.btnDobleReferencia.Location = new System.Drawing.Point(49, 157);
            this.btnDobleReferencia.Name = "btnDobleReferencia";
            this.btnDobleReferencia.Size = new System.Drawing.Size(187, 77);
            this.btnDobleReferencia.TabIndex = 3;
            this.btnDobleReferencia.Text = "Doble() Referencia";
            this.btnDobleReferencia.UseVisualStyleBackColor = true;
            this.btnDobleReferencia.Click += new System.EventHandler(this.btnDobleReferencia_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(48, 364);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(126, 30);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "lblResultado";
            // 
            // btnObjetoReferencia
            // 
            this.btnObjetoReferencia.Location = new System.Drawing.Point(47, 251);
            this.btnObjetoReferencia.Name = "btnObjetoReferencia";
            this.btnObjetoReferencia.Size = new System.Drawing.Size(189, 69);
            this.btnObjetoReferencia.TabIndex = 5;
            this.btnObjetoReferencia.Text = "Objeto Referencia";
            this.btnObjetoReferencia.UseVisualStyleBackColor = true;
            this.btnObjetoReferencia.Click += new System.EventHandler(this.btnObjetoReferencia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sólo números";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sólo letras";
            // 
            // txtSoloNumeros
            // 
            this.txtSoloNumeros.Location = new System.Drawing.Point(464, 42);
            this.txtSoloNumeros.Name = "txtSoloNumeros";
            this.txtSoloNumeros.Size = new System.Drawing.Size(278, 35);
            this.txtSoloNumeros.TabIndex = 8;
            this.txtSoloNumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloNumeros_KeyPress);
            // 
            // txtSoloLetras
            // 
            this.txtSoloLetras.Location = new System.Drawing.Point(464, 92);
            this.txtSoloLetras.Name = "txtSoloLetras";
            this.txtSoloLetras.Size = new System.Drawing.Size(278, 35);
            this.txtSoloLetras.TabIndex = 9;
            this.txtSoloLetras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloLetras_KeyPress);
            // 
            // lblMouse
            // 
            this.lblMouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblMouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMouse.Location = new System.Drawing.Point(316, 166);
            this.lblMouse.Name = "lblMouse";
            this.lblMouse.Size = new System.Drawing.Size(477, 244);
            this.lblMouse.TabIndex = 10;
            this.lblMouse.Text = "lblMouse";
            this.lblMouse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMouse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMouse_MouseMove);
            // 
            // Form12Metodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 440);
            this.Controls.Add(this.lblMouse);
            this.Controls.Add(this.txtSoloLetras);
            this.Controls.Add(this.txtSoloNumeros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnObjetoReferencia);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnDobleReferencia);
            this.Controls.Add(this.btnDobleValor);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form12Metodos";
            this.Text = "Form12Metodos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form12Metodos_FormClosed);
            this.Load += new System.EventHandler(this.Form12Metodos_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form12Metodos_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnDobleValor;
        private Button btnDobleReferencia;
        private Label lblResultado;
        private Button btnObjetoReferencia;
        private Label label2;
        private Label label3;
        private TextBox txtSoloNumeros;
        private TextBox txtSoloLetras;
        private Label lblMouse;
    }
}