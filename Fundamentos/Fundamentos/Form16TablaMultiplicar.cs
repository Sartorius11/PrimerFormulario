using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form16TablaMultiplicar : Form
    {
        List<TextBox> cajas;

        public Form16TablaMultiplicar()
        {
            InitializeComponent();
            this.cajas = new List<TextBox>();
            foreach (TextBox caja in this.groupBoxTabla.Controls)
            {
                this.cajas.Add(caja);
            }

            this.cajas.Reverse();

            for (int i = 0; i < cajas.Count; i++)
            {
                this.cajas[i].Text = i.ToString();
            }
        }

        private void btnMostrarTabla_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            for (int i = 0; i < this.cajas.Count; i++)
            {
                int operacion = numero * (i + 1);
                this.cajas[i].Text = operacion.ToString();
            }
        }
    }
}
