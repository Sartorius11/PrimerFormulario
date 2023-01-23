using System;
using System.Collections;
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
    public partial class Form13ArrayList : Form
    {
        public Form13ArrayList()
        {
            InitializeComponent();
            this.button3.Click += Button3_Click;


            List<Button> botones = new List<Button>();
            botones.Add(this.button1);
            botones.Add(this.button2);
            botones.Add(this.button3);
            //SE ACCEDE DIRECTO A SUS PROPIEDADES/METODOS
            botones[0].BackColor = Color.AntiqueWhite;
            //CONTROL DE ERRORES DE COMPILACION
            //botones.Add(this.textBox1);



            //VAMOS A TENER UNA COLECCION NO TIPADA
            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);

            coleccion.Add(this.textBox1);
            //SI INTENTAMOS ACCEDER A LAS PROPIEDADES
            //NO LAS VEREMOS
            ((Button)coleccion[0]).Text = "Soy un botón";
            //LOS BUCLE FOREACH PUEDEN REALIZAR EL CASTING DE 
            //FORMA AUTOMATICA
            //foreach (Button boton in coleccion)
            //{
            //    boton.BackColor = Color.Yellow;
            //}

            //DEBEMOS UTILIZAR LA ABSTRACCION PARA RECORRER TODOS
            //LOS OBJETOS DISTINTOS CON UN TIPO
            foreach (Control control in coleccion)
            {
                control.BackColor = Color.Yellow;
                //TAMBIEN PODEMOS MANEJAR LOS OBJETOS
                //POR SU CLASE CON PROPIEDADES ESPECIFICAS DEL OBJETO
                //PARA ELLO, DEBEMOS PREGUNTAR Y HACER CASTING
                //QUIERO PEGAR EL CONTENIDO DEL PORTAPAPELES
                // Paste()
                if (control is TextBox)
                {
                    ((TextBox)control).Paste();
                }
            }
        
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.button3.Text = "Pulsado";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Text = "Accion";
        }
    }
}
