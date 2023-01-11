namespace Fundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //AQUI ESCRIBIREMOS NUESTRAS ACCIONES AL PULSAR EL BOTON
            //TENEMOS PROPIEDADES DE TIPO PRIMITIVO
            this.txtNombre.Width = 50;
            this.btnPulsar.Text = "Boton pulsado!!!";
            //TENEMOS PROPIEDADES QUE SON DE TIPO OBJETO
            this.txtNombre.Location = new Point(70, 100);
            //TENEMOS PROPIEDADES DE TIPO ENUMERADAS
            //UNA ENUMERACION SON UNA SERUE DE VALORES QUE
            //SE REPRESENTA DE FORMA GRAFICA Y AYUDAN AL PROGRAMADOR
            this.txtNombre.TextAlign = HorizontalAlignment.Center;
            this.BackColor = Color.Beige;
        }
    }
}