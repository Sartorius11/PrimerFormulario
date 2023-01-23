namespace Fundamentos
{
    partial class Form22Mascotas
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.btnNuevoRegistro = new System.Windows.Forms.Button();
            this.btnLeerRegistros = new System.Windows.Forms.Button();
            this.btnGuardarRegistros = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstMascotas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(30, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(225, 35);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Raza";
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(31, 146);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(224, 35);
            this.txtRaza.TabIndex = 3;
            // 
            // btnNuevoRegistro
            // 
            this.btnNuevoRegistro.Location = new System.Drawing.Point(34, 204);
            this.btnNuevoRegistro.Name = "btnNuevoRegistro";
            this.btnNuevoRegistro.Size = new System.Drawing.Size(221, 44);
            this.btnNuevoRegistro.TabIndex = 4;
            this.btnNuevoRegistro.Text = "Nuevo registro";
            this.btnNuevoRegistro.UseVisualStyleBackColor = true;
            this.btnNuevoRegistro.Click += new System.EventHandler(this.btnNuevoRegistro_Click);
            // 
            // btnLeerRegistros
            // 
            this.btnLeerRegistros.Location = new System.Drawing.Point(37, 270);
            this.btnLeerRegistros.Name = "btnLeerRegistros";
            this.btnLeerRegistros.Size = new System.Drawing.Size(218, 55);
            this.btnLeerRegistros.TabIndex = 5;
            this.btnLeerRegistros.Text = "Leer registros";
            this.btnLeerRegistros.UseVisualStyleBackColor = true;
            this.btnLeerRegistros.Click += new System.EventHandler(this.btnLeerRegistros_Click);
            // 
            // btnGuardarRegistros
            // 
            this.btnGuardarRegistros.Location = new System.Drawing.Point(39, 339);
            this.btnGuardarRegistros.Name = "btnGuardarRegistros";
            this.btnGuardarRegistros.Size = new System.Drawing.Size(216, 87);
            this.btnGuardarRegistros.TabIndex = 6;
            this.btnGuardarRegistros.Text = "Guardar registros";
            this.btnGuardarRegistros.UseVisualStyleBackColor = true;
            this.btnGuardarRegistros.Click += new System.EventHandler(this.btnGuardarRegistros_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            this.lstMascotas.FormattingEnabled = true;
            this.lstMascotas.ItemHeight = 30;
            this.lstMascotas.Location = new System.Drawing.Point(307, 56);
            this.lstMascotas.Name = "lstMascotas";
            this.lstMascotas.Size = new System.Drawing.Size(289, 394);
            this.lstMascotas.TabIndex = 8;
            this.lstMascotas.SelectedIndexChanged += new System.EventHandler(this.lstMascotas_SelectedIndexChanged);
            // 
            // Form22Mascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 472);
            this.Controls.Add(this.lstMascotas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardarRegistros);
            this.Controls.Add(this.btnLeerRegistros);
            this.Controls.Add(this.btnNuevoRegistro);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form22Mascotas";
            this.Text = "Form22Mascotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtRaza;
        private Button btnNuevoRegistro;
        private Button btnLeerRegistros;
        private Button btnGuardarRegistros;
        private Label label3;
        private ListBox lstMascotas;
    }
}