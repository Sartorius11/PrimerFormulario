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
    public partial class Form10ColeccionNumeros : Form
    {
        public Form10ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.lstNumeros.Items.Clear();
            for (int i = 1; i <= 8; i++)
            {
                int aleat = random.Next(1, 100);
                this.lstNumeros.Items.Add(aleat);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int suma = 0, sumaPares = 0, sumaImpares = 0;
            foreach (int num in this.lstNumeros.Items)
            {
                suma += num;
                if (num%2 == 0)
                {
                    sumaPares += num;
                }
                else
                {
                    sumaImpares += num;
                }
            }
            this.txtSuma.Text = suma.ToString();
            this.txtPares.Text = sumaPares.ToString();
            this.txtImpares.Text = sumaImpares.ToString();
        }
    }
}
