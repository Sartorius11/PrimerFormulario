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
    public partial class Form17Temperaturas : Form
    {
        List<int> temperaturas;

        public Form17Temperaturas()
        {
            InitializeComponent();
            this.temperaturas = new List<int>();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.temperaturas.Clear();
            this.lstMeses.Items.Clear();
            Random random = new Random();
            DateTime fecha = DateTime.Parse("01/01/2023");
            for (int i = 1; i <= 12; i++)
            {
                int temp = random.Next(-20, 40);
                this.temperaturas.Add(temp);
                string nombreMes = fecha.ToString("MMMM");
                fecha = fecha.AddMonths(1);
                this.lstMeses.Items.Add(nombreMes + ": " + temp);
                //this.lstMeses.Items.Add(nombreMes);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int maxima = 0;
            int minima = 0;
            int media = 0;
            int suma = 0;
            foreach (int temp in this.temperaturas)
            {
                maxima = Math.Max(maxima, temp);
                minima = Math.Min(minima, temp);
                suma += temp;
            }
            media = suma / this.temperaturas.Count;
            this.txtTemperaturaMaxima.Text = maxima.ToString();
            this.txtTemperaturaMinima.Text = minima.ToString();
            this.txtTemperaturaMedia.Text = media.ToString();
        }
    }
}
