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
    public partial class Form04DateTime : Form
    {
        public Form04DateTime()
        {
            InitializeComponent();
            this.txtFechaActual.Text = DateTime.Now.ToString();
        }

        private void chkFormato_CheckedChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);
            if (this.chkFormato.Checked == true)
            {
                this.txtFechaActual.Text = fecha.ToShortDateString();
            }
            else
            {
                this.txtFechaActual.Text = fecha.ToLongDateString();
            }
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtIncremento.Text);
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);
            if (this.rdbDias.Checked == true)
            {
                fecha = fecha.AddDays(incremento);
            }else if (this.rdbMeses.Checked == true)
            {
                fecha = fecha.AddMonths(incremento);
            }
            else
            {
                fecha = fecha.AddYears(incremento);
            }
            this.txtNuevaFecha.Text = fecha.ToString();
        }
    }
}
