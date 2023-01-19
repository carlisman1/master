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
    public partial class Form02ColoresPosicion : Form
    {
        public Form02ColoresPosicion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = int.Parse(this.txtR.Text);
            int g = int.Parse(this.txtG.Text);
            int b = int.Parse(this.txtB.Text);
            //LOS COLORES SON ENTRE 0 Y 255
            if (r < 0 || r > 255)
            {
                MessageBox.Show("El color rojo debe estar entre 0 y 255");
            }else if (g < 0 || g > 255)
            {
                MessageBox.Show("El color verde debe estar entre 0 y 255");
            }
            else if (b < 0 || b > 255)
            {
                MessageBox.Show("El color Azul debe estar entre 0 y 255");
            }
            else
            {
                this.BackColor = Color.FromArgb(r, g, b);
            }

        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            int x = int.Parse(this.txtX.Text);
            int y = int.Parse(this.txtY.Text);
            this.btnPosicion.Location = new Point(x,y);
        }
    }
}
