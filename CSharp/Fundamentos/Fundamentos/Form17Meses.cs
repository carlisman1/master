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
    public partial class Form17Meses : Form
    {
        List<string> meses;
        List<int> temperaturas;
        int maxima = 0;
        int minima = 0;
        int media = 0;
        public Form17Meses()
        {
            InitializeComponent();
            this.temperaturas = new List<int>();
            this.meses = new List<string>() { "Enero", "Febrero", "Marzo", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < meses.Count; i++)
            {
                Random random = new Random();
                int num = random.Next(-50,50);
                temperaturas.Add(num);
                this.listBox1.Items.Add(meses[i] + num);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = temperaturas.Max().ToString();
            this.textBox2.Text = temperaturas.Min().ToString();
            this.textBox3.Text = ((int)temperaturas.Average()).ToString();
        }
    }
}
