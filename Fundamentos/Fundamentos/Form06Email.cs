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
    public partial class Form06Email : Form
    {
        public Form06Email()
        {
            InitializeComponent();
        }

        private void btnValidarEmail_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;
            if (email.IndexOf("@") == -1)
            {
                this.lblResultado.Text = "No existe @";
            }else if (email.StartsWith("@") || email.EndsWith("@"))
            {
                this.lblResultado.Text = "@ al inicio o al final";
            }else if (email.IndexOf("@") != email.LastIndexOf("@"))
            {
                this.lblResultado.Text = "Existe más de una @";
            }else if (email.Contains(".") == false)
            {
                this.lblResultado.Text = "No existe punto";
            }else if (email.LastIndexOf(".") < email.IndexOf("@"))
            {
                this.lblResultado.Text = "Debe existir un punto después de @";
            }
            else
            {
                int ultimoPunto = email.LastIndexOf(".");
                string dominio = email.Substring(ultimoPunto + 1);
                if (dominio.Length >= 2 && dominio.Length <= 4)
                {
                    this.lblResultado.Text = "Email CORRECTO!!!";
                }
                else
                {
                    this.lblResultado.Text = "Dominio debe ser de 2 a 4 caracteres";
                }
            }

        }
    }
}
