namespace Fundamentos
{
    partial class Form24ColeccionXMLMascotas
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
            this.txtAnyos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardarRegistros = new System.Windows.Forms.Button();
            this.btnLeerRegistros = new System.Windows.Forms.Button();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstMascotas = new System.Windows.Forms.ListBox();
            this.btnNuevaMascota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAnyos
            // 
            this.txtAnyos.Location = new System.Drawing.Point(34, 252);
            this.txtAnyos.Name = "txtAnyos";
            this.txtAnyos.Size = new System.Drawing.Size(100, 35);
            this.txtAnyos.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 30);
            this.label3.TabIndex = 21;
            this.label3.Text = "Años";
            // 
            // btnGuardarRegistros
            // 
            this.btnGuardarRegistros.Location = new System.Drawing.Point(302, 176);
            this.btnGuardarRegistros.Name = "btnGuardarRegistros";
            this.btnGuardarRegistros.Size = new System.Drawing.Size(216, 61);
            this.btnGuardarRegistros.TabIndex = 20;
            this.btnGuardarRegistros.Text = "Guardar Registros";
            this.btnGuardarRegistros.UseVisualStyleBackColor = true;
            this.btnGuardarRegistros.Click += new System.EventHandler(this.btnGuardarRegistros_Click);
            // 
            // btnLeerRegistros
            // 
            this.btnLeerRegistros.Location = new System.Drawing.Point(302, 105);
            this.btnLeerRegistros.Name = "btnLeerRegistros";
            this.btnLeerRegistros.Size = new System.Drawing.Size(218, 55);
            this.btnLeerRegistros.TabIndex = 19;
            this.btnLeerRegistros.Text = "Leer Registros";
            this.btnLeerRegistros.UseVisualStyleBackColor = true;
            this.btnLeerRegistros.Click += new System.EventHandler(this.btnLeerRegistros_Click);
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(29, 156);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(224, 35);
            this.txtRaza.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "Raza";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(28, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(225, 35);
            this.txtNombre.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 30);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            this.lstMascotas.FormattingEnabled = true;
            this.lstMascotas.ItemHeight = 30;
            this.lstMascotas.Location = new System.Drawing.Point(557, 55);
            this.lstMascotas.Name = "lstMascotas";
            this.lstMascotas.Size = new System.Drawing.Size(263, 304);
            this.lstMascotas.TabIndex = 24;
            this.lstMascotas.SelectedIndexChanged += new System.EventHandler(this.lstMascotas_SelectedIndexChanged);
            // 
            // btnNuevaMascota
            // 
            this.btnNuevaMascota.Location = new System.Drawing.Point(304, 34);
            this.btnNuevaMascota.Name = "btnNuevaMascota";
            this.btnNuevaMascota.Size = new System.Drawing.Size(214, 51);
            this.btnNuevaMascota.TabIndex = 25;
            this.btnNuevaMascota.Text = "Nueva mascota";
            this.btnNuevaMascota.UseVisualStyleBackColor = true;
            this.btnNuevaMascota.Click += new System.EventHandler(this.btnNuevaMascota_Click);
            // 
            // Form24ColeccionXMLMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 390);
            this.Controls.Add(this.btnNuevaMascota);
            this.Controls.Add(this.lstMascotas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAnyos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardarRegistros);
            this.Controls.Add(this.btnLeerRegistros);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form24ColeccionXMLMascotas";
            this.Text = "Form24ColeccionXMLMascotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtAnyos;
        private Label label3;
        private Button btnGuardarRegistros;
        private Button btnLeerRegistros;
        private TextBox txtRaza;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private Label label4;
        private ListBox lstMascotas;
        private Button btnNuevaMascota;
    }
}