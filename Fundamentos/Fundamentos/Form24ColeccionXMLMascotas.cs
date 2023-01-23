using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using ProyectoClases.Models;

namespace Fundamentos
{
    public partial class Form24ColeccionXMLMascotas : Form
    {
        XmlSerializer serializer;
        List<Mascota> coleccionMascotas;

        public Form24ColeccionXMLMascotas()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(List<Mascota>));
            this.coleccionMascotas = new List<Mascota>();
        }

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Years = int.Parse(this.txtAnyos.Text);
            this.coleccionMascotas.Add(mascota);
            this.txtNombre.Text = "";
            this.txtRaza.Text = "";
            this.txtAnyos.Text = "";
            this.DibujarMascotas();
        }

        private void DibujarMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in this.coleccionMascotas)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }

        private async void btnGuardarRegistros_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("coleccionmascotas.xml"))
            {
                this.serializer.Serialize(writer, this.coleccionMascotas);
                await writer.FlushAsync();
                writer.Close();
            }
            this.lstMascotas.Items.Clear();
            this.coleccionMascotas.Clear();
        }

        private void btnLeerRegistros_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("coleccionmascotas.xml"))
            {
                this.coleccionMascotas =
                    (List<Mascota>)this.serializer.Deserialize(reader);
                reader.Close();
            }
            this.DibujarMascotas();
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.lstMascotas.SelectedIndex;
            if (indice != -1)
            {
                Mascota mascota = this.coleccionMascotas[indice];
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
                this.txtAnyos.Text = mascota.Years.ToString();
            }
        }
    }
}
