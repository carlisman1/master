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

            //CONVERSION AUTOMATICA
            short numero = 99;
            int mayor = numero;

            //CASTING ENTRE OBJETOS
            int numeroMayor = 99;
            short numeroMenor = 888;
            //NECESITAMOS ALMACENAR EN EL MENOR
            //EL DATO DEL MAYOR
            numeroMenor = (short) numeroMayor;

            //CONVERTIR STRING A PRIMITIVO
            string textoNumero = "1444";
            int numeroEntero = int.Parse(textoNumero);
            double doble = double.Parse(textoNumero);


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sumarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form01SumarNumeros formSuma = new Form01SumarNumeros();
            formSuma.ShowDialog();
        }

        private void posicionYColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form02ColoresPosicion formPyC = new Form02ColoresPosicion();
            formPyC.ShowDialog();
        }

        private void calcularDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form03CaclularDia formCalcular = new Form03CaclularDia();
            formCalcular.ShowDialog();
        }

        private void incrementarFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form04Fecha formFecha = new Form04Fecha();
            formFecha.ShowDialog();
        }

        private void charToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form05Char formChar = new Form05Char();
            formChar.ShowDialog();
        }

        private void validarEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form06Email formEmail = new Form06Email();
            formEmail.ShowDialog();
        }

        private void sumarNumeros07ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form07SumarNumeros formSumarNumeros = new Form07SumarNumeros();
            formSumarNumeros.ShowDialog();
        }

        private void coleccionesGraficasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form08ColeccionGrafica formColeccion = new Form08ColeccionGrafica();
            formColeccion.ShowDialog();
        }

        private void colecciobesMultiplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form09ColeccionMultiple fromMultiple = new Form09ColeccionMultiple();
            fromMultiple.ShowDialog();

        }

        private void randomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10Random formRandom = new Form10Random();
            formRandom.ShowDialog();
        }

        private void tiendaProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11TiendaProductos formTienda = new Form11TiendaProductos();
            formTienda.ShowDialog();
        }

        private void metodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12Metodos formMetodos = new Form12Metodos();    
            formMetodos.ShowDialog();

        }

        private void arrayListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13ArrayList formArray = new Form13ArrayList();
            formArray.ShowDialog();
        }

        private void listEvenetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14ListEventos formListEventos = new Form14ListEventos();
            formListEventos.ShowDialog();
        }

        private void sumarBotonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15SumarBotones formSumarBotones = new Form15SumarBotones();
            formSumarBotones.ShowDialog();
        }

        private void tablaMultiplicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form16TablaMultipicar formTablaMulti = new Form16TablaMultipicar();
            formTablaMulti.ShowDialog();
        }

        private void mesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form17Meses formMeses = new Form17Meses();
            formMeses.ShowDialog();
        }

        private void clasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form18PruebaClases formClases = new Form18PruebaClases();
            formClases.ShowDialog();
        }

        private void temperaturasClasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form19TemperaturaClases formTemperatura = new Form19TemperaturaClases();
            formTemperatura.ShowDialog();
        }

        private void readWriteFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form21Files formFiles = new Form21Files();  
            formFiles.ShowDialog();
        }

        private void mascotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form22Mascotas formMascotas = new Form22Mascotas();
            formMascotas.ShowDialog();
        }

        private void objetosXMLMascotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form23ObjetoXMLMascota formXml = new Form23ObjetoXMLMascota();
            formXml.ShowDialog();
        }

        private void coleccionesXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form24ColeccionXml formColeccionesXml = new Form24ColeccionXml();
            formColeccionesXml.ShowDialog();
        }
    }
}