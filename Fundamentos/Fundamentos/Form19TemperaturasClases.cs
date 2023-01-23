using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace Fundamentos
{
    public partial class Form19TemperaturasClases : Form
    {
        List<Mes> meses;

        public Form19TemperaturasClases()
        {
            InitializeComponent();
            this.meses = new List<Mes>();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.lstMeses.Items.Clear();
            this.meses.Clear();
            Random random = new Random();
            DateTime tiempo = DateTime.Parse("01/01/2023");
            for (int i = 1; i <= 12; i++)
            {
                Mes mes = new Mes();
                string nombremes = tiempo.ToString("MMMM").ToUpper();
                mes.NombreMes = nombremes;
                mes.TemperaturaMaxima = random.Next(10, 50);
                mes.TemperaturaMinima = random.Next(-10, 9);
                this.meses.Add(mes);
                this.lstMeses.Items.Add(nombremes);
                tiempo = tiempo.AddMonths(1);
            }
        }

        private void lstMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstMeses.SelectedIndex != -1)
            {
                int indice = this.lstMeses.SelectedIndex;
                Mes mes = this.meses[indice];
                this.txtTemperaturaMaxima.Text = mes.TemperaturaMaxima.ToString();
                this.txtTemperaturaMinima.Text = mes.TemperaturaMinima.ToString();
                this.txtTemperaturaMedia.Text = mes.GetTemperaturaMedia().ToString();
            }
        }
    }
}
