namespace Fundamentos
{
    partial class Form23ObjetoXMLMascota
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
            this.btnGuardarDato = new System.Windows.Forms.Button();
            this.btnLeerDato = new System.Windows.Forms.Button();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnyos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuardarDato
            // 
            this.btnGuardarDato.Location = new System.Drawing.Point(304, 177);
            this.btnGuardarDato.Name = "btnGuardarDato";
            this.btnGuardarDato.Size = new System.Drawing.Size(216, 61);
            this.btnGuardarDato.TabIndex = 12;
            this.btnGuardarDato.Text = "Guardar Dato";
            this.btnGuardarDato.UseVisualStyleBackColor = true;
            this.btnGuardarDato.Click += new System.EventHandler(this.btnGuardarDato_Click);
            // 
            // btnLeerDato
            // 
            this.btnLeerDato.Location = new System.Drawing.Point(302, 93);
            this.btnLeerDato.Name = "btnLeerDato";
            this.btnLeerDato.Size = new System.Drawing.Size(218, 55);
            this.btnLeerDato.TabIndex = 11;
            this.btnLeerDato.Text = "Leer Dato";
            this.btnLeerDato.UseVisualStyleBackColor = true;
            this.btnLeerDato.Click += new System.EventHandler(this.btnLeerDato_Click);
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(31, 157);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(224, 35);
            this.txtRaza.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Raza";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(30, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(225, 35);
            this.txtNombre.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Años";
            // 
            // txtAnyos
            // 
            this.txtAnyos.Location = new System.Drawing.Point(36, 253);
            this.txtAnyos.Name = "txtAnyos";
            this.txtAnyos.Size = new System.Drawing.Size(100, 35);
            this.txtAnyos.TabIndex = 14;
            // 
            // Form23ObjetoXMLMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 312);
            this.Controls.Add(this.txtAnyos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardarDato);
            this.Controls.Add(this.btnLeerDato);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form23ObjetoXMLMascota";
            this.Text = "Form23ObjetoXMLMascota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGuardarDato;
        private Button btnLeerDato;
        private TextBox txtRaza;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private Label label3;
        private TextBox txtAnyos;
    }
}