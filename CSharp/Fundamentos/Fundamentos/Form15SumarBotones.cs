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
    public partial class Form15SumarBotones : Form
    {
        //DECLARAMOS LA COLECCION A NIVEL DE CLASE
        List<Button> botones;
        //NECESITAMOS UNA VARIABLE PARA ALMACENAR EL
        //VALOR ACTUAL DE LA SUMA A NIVEL DE CLASE
        int suma;
        public Form15SumarBotones()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            this.suma = 0;
            //RECORREMOS TODA LA COLECCION CONTROL Y ACCEDEMOS A CADA
            //UNO DE LOS BOTONES
            //foreach(Control control in this.Controls)
            //{
            //    if(control is Button)
            //    {
            //        this.botones.Add((Button)control);
            //    }
            //}

            foreach (Control control in this.panelBotones.Controls)
            {
                if (control is Button)
                {
                    this.botones.Add((Button)control);
                }
            }

            //RECORREMOS LOS CONTROLES Y ASIGANMOS UN NUMERO
            //RANDOM EN CADA UNO
            Random random = new Random();
            foreach (Button boton in botones)
            {
                int num = random.Next(1, 200);
                boton.Text = num.ToString();
                boton.Click += SumarNumeros;
            }
        }
        private void SumarNumeros ( object? sender, EventArgs e)
        {
            //RECUPERAMOS EL NUMERO DEL CONTROL PULSADO
            Button boton = (Button)sender;
            int numero = int.Parse(boton.Text);
            this.suma += numero;
            this.txtSuma.Text = this.suma.ToString();
            boton.BackColor = Color.Yellow;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.suma = 0;
            this.txtSuma.Text = "0";
            foreach (Button boton in botones)
            {
                int num = random.Next(1, 200);
                boton.Text = num.ToString();
                boton.BackColor = Color.FromKnownColor(KnownColor.ButtonFace);
            }
        }
    }
}
