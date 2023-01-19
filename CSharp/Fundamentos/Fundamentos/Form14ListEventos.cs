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
    public partial class Form14ListEventos : Form
    {
        // Declaramos la coleccion a nivel clase para utilizarla en otros eventos
        // Vamos a rellenar la coleccion con todos los botones del dibujo
        readonly List<Button> buttons = new();
        /*
            Vamos a tener una variable contador.
            Las variables a nivel clase mantienen su valor mientras estemos trabajando con esta clase
         */
        int contador;
        public Form14ListEventos()
        {
            InitializeComponent();
            this.contador = 0;
            this.buttons = new List<Button>();
            /*
                Dentro de la clase Control (Form) hay una coleccion llamda Controls que contiene el Form.
                La norma es tener nuestras propias colecciones, no las del Form
             */
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    this.buttons.Add(button);
                    control.BackColor = Color.Yellow;
                }
            }
            /*
                Recorremos los botones
             */
            foreach (Button button in buttons)
            {
                button.Click += BotonPulsado;
            }

        }
        public void BotonPulsado(object? sender, EventArgs e)
        {
            this.contador += 1;
            this.textBox1.Text = "Contador: " + this.contador.ToString();
            //NECESITO ACCEDER AL BOTON, CUANDO PULSEMOS SOBRE EL 
            //BOTON, CAMBIAMOS SU COLOR
            Button boton = (Button)sender;
        }

        private void Form14ListEventos_Load(object sender, EventArgs e)
        {

        }
    }
}
