namespace Fundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            //AQUI ESCRIBIREMOS NUESTRAS ACCIONES AL PULSAR EL BOTON
            //TENEMOS PROPIEDADES DE TIPO PRIMITIVO
            this.txtNombre.Width = 150;
            this.btnPulsar.Text = "Botón pulsado!!!";
            //TENEMOS PROPIEDADES QUE SON DE TIPO OBJETO
            this.txtNombre.Location = new Point(70, 100);
            //TENEMOS PROPIEDADES DE TIPO ENUMERADAS
            //UNA ENUMERACION SON UNA SERIE DE VALORES QUE 
            //SE REPRESENTAN DE FORMA GRAFICA Y AYUDAN AL 
            //PROGRAMADOR
            this.txtNombre.TextAlign = HorizontalAlignment.Center;
            this.BackColor = Color.Beige;
            this.btnPulsar.BackColor = Color.LightGreen;

            //CONVERSION AUTOMATICA
            short numero = 99;
            int mayor = numero;

            //CASTING ENTRE OBJETOS
            int numeroMayor = 99;
            short numeroMenor = 888;
            //NECESITAMOS ALMACENAR EN
            //EL NUMERO MENOR EL DATO DEL MAYOR
            numeroMenor = (short) numeroMayor;

            //CONVERTIR STRING A PRIMITIVO
            string textoNumero = "1444";
            int numeroEntero = int.Parse(textoNumero);
            double doble = double.Parse(textoNumero);

            //CONVERTIR OBJETOS A STRING
            int valor = 8888;
            string texto = valor.ToString();
            string boton = this.btnPulsar.ToString();





        }
    }
}