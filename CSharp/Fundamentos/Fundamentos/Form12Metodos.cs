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
    public partial class Form12Metodos : Form
    {
        public Form12Metodos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            this.GetDoble(num);
            this.lblRes.Text = num.ToString();
        }
        void GetDoble(int numero)
        {
            //CAMBIAMOS EL VALOR DEL PARAMETRO WRAPPER RECIBIDO
            numero = numero * 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.btnDobleReferencia);
            this.CambiarColor(this.btnDoble);
        }

        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.Yellow;
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            //TANTO EN EL METODO COMO EN LA LLAMADA
            //DEBEMOS UTILIZAR ref

            //this.GetDobleReferencia(ref num);
            int resultado = this.GetDobleReferencia(ref num);
            this.lblRes.Text = num.ToString();
        }

        //void GetDobleReferencia(ref int numero)
        //{
        //    //CAMBIAMOS EL VALOR DE LA VARIABLE
        //    numero = numero * 2;
        //}
        int GetDobleReferencia(ref int numero)
        {
            int doble = numero * 2;
            return doble;
        }

        private void lblMouse_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblMouse.Text = "X: " + e.X + ", Y:" + e.Y;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //LA TECLA PULSADA
            //e.KeyChar
            //DESACTIVA LAS ACCIONES POSTERIORES AL EVENTO
            //e.Handled = true;
            //DEBEMOS INDICAR QUE SI LA TECLA DE BORRAR,
            //TAMBIEN ESTA HABILITADO EL EVENTO

            //EXISTE UNA ENUMERACION QUE NOS DEVUELVE
            //EL CODIGO DE CADA TECLA
            char teclaBorrar = (char) Keys.Back;
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }
    }
}
