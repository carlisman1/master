using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace Fundamentos
{
    public partial class Form19TemperaturaClases : Form
    {
        List<string> meses;
         
        List<Temperatura> temperaturas;
        int maxima = 0;
        int minima = 0;
        int media = 0;
        public Form19TemperaturaClases()
        {
            InitializeComponent();
            this.temperaturas = new List<Temperatura>();
            this.meses = new List<string>() { "Enero", "Febrero", "Marzo", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < meses.Count; i++)
            {
                Random random = new Random();
                int num = random.Next(-50, 50);
                //temperaturas.Add();
                this.listBox1.Items.Add(meses[i] + num);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
