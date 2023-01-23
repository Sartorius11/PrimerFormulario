using ProyectoClases;
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
    public partial class Form20TemperaturasAnuales : Form
    {
        List<ClaseAnual> years;
        ClaseAnual anyoSeleccionado;

        public Form20TemperaturasAnuales()
        {
            InitializeComponent();
            this.years = new List<ClaseAnual>();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int numAnyo = 2018;
            for (int i = 1; i <= 5; i++)
            {
                ClaseAnual anual = new ClaseAnual(numAnyo);
                this.years.Add(anual);
                this.cmbYears.Items.Add("Año " + numAnyo);
                numAnyo += 1;
            }
        }

        private void cmbYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.cmbYears.SelectedIndex;
            this.anyoSeleccionado = this.years[indice];
            this.txtMaximaAnual.Text = this.anyoSeleccionado.GetMaximaAnual().ToString();
            this.txtMinimaAnual.Text = this.anyoSeleccionado.GetMinimaAnual().ToString();
            this.txtMediaAnual.Text = this.anyoSeleccionado.GetMediaAnual().ToString();
            this.lstMeses.Items.Clear();
            foreach (Mes mes in this.anyoSeleccionado.Meses)
            {
                this.lstMeses.Items.Add(mes.NombreMes);
            }
        }

        private void lstMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstMeses.SelectedIndex != -1)
            {
                int indiceMesSeleccionado = this.lstMeses.SelectedIndex;
                Mes mes = this.anyoSeleccionado.Meses[indiceMesSeleccionado];
                this.txtTemperaturaMaxima.Text = mes.TemperaturaMaxima.ToString();
                this.txtTemperaturaMinima.Text = mes.TemperaturaMinima.ToString();
                this.txtTemperaturaMedia.Text = mes.GetTemperaturaMedia().ToString();
            }
        }
    }
}
