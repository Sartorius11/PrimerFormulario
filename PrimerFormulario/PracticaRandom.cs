using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerFormulario
{
    public partial class PracticaRandom : Form
    {
        public PracticaRandom()
        {
            InitializeComponent();
            this.lstNumeros.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int valor = random.Next(1, 200);
            this.lstNumeros.Items.Add(valor);
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int pares = 0;
            int impares = 0;

            for (int i = 0; i < this.lstNumeros.Items.Count; i++)
            {
                if (int.Parse(lstNumeros.Items[i].ToString()) % 2 == 0)
                {
                    pares += int.Parse(lstNumeros.Items[i].ToString());
                }
                else
                {
                    impares += int.Parse(lstNumeros.Items[i].ToString());
                }

                suma += int.Parse(lstNumeros.Items[i].ToString());
            }
            this.txtSuma.Text = suma.ToString();
            this.txtPares.Text = pares.ToString();
            this.txtImpares.Text = impares.ToString();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int pares = 0;
            int impares = 0;

            for (int i = 0; i < this.lstNumeros.SelectedItems.Count; i++)
            {
                if (int.Parse(lstNumeros.SelectedItems[i].ToString()) % 2 == 0)
                {
                    pares += int.Parse(lstNumeros.SelectedItems[i].ToString());
                }
                else
                {
                    impares += int.Parse(lstNumeros.SelectedItems[i].ToString());
                }

                suma += int.Parse(lstNumeros.SelectedItems[i].ToString());
            }
            this.txtSuma.Text = suma.ToString();
            this.txtPares.Text = pares.ToString();
            this.txtImpares.Text = impares.ToString();
        }
    }
}

