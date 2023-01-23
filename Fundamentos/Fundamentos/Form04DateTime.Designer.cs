namespace Fundamentos
{
    partial class Form04DateTime
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
            this.txtFechaActual = new System.Windows.Forms.TextBox();
            this.chkFormato = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIncrementar = new System.Windows.Forms.Button();
            this.txtIncremento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbAnyos = new System.Windows.Forms.RadioButton();
            this.rdbMeses = new System.Windows.Forms.RadioButton();
            this.rdbDias = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNuevaFecha = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha actual";
            // 
            // txtFechaActual
            // 
            this.txtFechaActual.Location = new System.Drawing.Point(39, 65);
            this.txtFechaActual.Name = "txtFechaActual";
            this.txtFechaActual.Size = new System.Drawing.Size(595, 35);
            this.txtFechaActual.TabIndex = 1;
            // 
            // chkFormato
            // 
            this.chkFormato.AutoSize = true;
            this.chkFormato.Location = new System.Drawing.Point(40, 120);
            this.chkFormato.Name = "chkFormato";
            this.chkFormato.Size = new System.Drawing.Size(252, 34);
            this.chkFormato.TabIndex = 2;
            this.chkFormato.Text = "Cambiar Formato Fecha";
            this.chkFormato.UseVisualStyleBackColor = true;
            this.chkFormato.CheckedChanged += new System.EventHandler(this.chkFormato_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIncrementar);
            this.groupBox1.Controls.Add(this.txtIncremento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdbAnyos);
            this.groupBox1.Controls.Add(this.rdbMeses);
            this.groupBox1.Controls.Add(this.rdbDias);
            this.groupBox1.Location = new System.Drawing.Point(41, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 169);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incrementar fecha";
            // 
            // btnIncrementar
            // 
            this.btnIncrementar.Location = new System.Drawing.Point(226, 99);
            this.btnIncrementar.Name = "btnIncrementar";
            this.btnIncrementar.Size = new System.Drawing.Size(229, 40);
            this.btnIncrementar.TabIndex = 5;
            this.btnIncrementar.Text = "Incrementar";
            this.btnIncrementar.UseVisualStyleBackColor = true;
            this.btnIncrementar.Click += new System.EventHandler(this.btnIncrementar_Click);
            // 
            // txtIncremento
            // 
            this.txtIncremento.Location = new System.Drawing.Point(340, 42);
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.Size = new System.Drawing.Size(115, 35);
            this.txtIncremento.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Incremento";
            // 
            // rdbAnyos
            // 
            this.rdbAnyos.AutoSize = true;
            this.rdbAnyos.Location = new System.Drawing.Point(29, 126);
            this.rdbAnyos.Name = "rdbAnyos";
            this.rdbAnyos.Size = new System.Drawing.Size(78, 34);
            this.rdbAnyos.TabIndex = 2;
            this.rdbAnyos.TabStop = true;
            this.rdbAnyos.Text = "Años";
            this.rdbAnyos.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            this.rdbMeses.AutoSize = true;
            this.rdbMeses.Location = new System.Drawing.Point(32, 84);
            this.rdbMeses.Name = "rdbMeses";
            this.rdbMeses.Size = new System.Drawing.Size(90, 34);
            this.rdbMeses.TabIndex = 1;
            this.rdbMeses.TabStop = true;
            this.rdbMeses.Text = "Meses";
            this.rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbDias
            // 
            this.rdbDias.AutoSize = true;
            this.rdbDias.Location = new System.Drawing.Point(34, 42);
            this.rdbDias.Name = "rdbDias";
            this.rdbDias.Size = new System.Drawing.Size(71, 34);
            this.rdbDias.TabIndex = 0;
            this.rdbDias.TabStop = true;
            this.rdbDias.Text = "Dias";
            this.rdbDias.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nueva fecha";
            // 
            // txtNuevaFecha
            // 
            this.txtNuevaFecha.Location = new System.Drawing.Point(45, 405);
            this.txtNuevaFecha.Name = "txtNuevaFecha";
            this.txtNuevaFecha.Size = new System.Drawing.Size(589, 35);
            this.txtNuevaFecha.TabIndex = 5;
            // 
            // Form04DateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 468);
            this.Controls.Add(this.txtNuevaFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkFormato);
            this.Controls.Add(this.txtFechaActual);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form04DateTime";
            this.Text = "Form04DateTime";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtFechaActual;
        private CheckBox chkFormato;
        private GroupBox groupBox1;
        private Button btnIncrementar;
        private TextBox txtIncremento;
        private Label label2;
        private RadioButton rdbAnyos;
        private RadioButton rdbMeses;
        private RadioButton rdbDias;
        private Label label3;
        private TextBox txtNuevaFecha;
    }
}