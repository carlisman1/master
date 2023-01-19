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
    public partial class Form04Fecha : Form
    {
        public Form04Fecha()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtIncremento.Text);
            DateTime fecha =DateTime.Parse(this.txtFA.Text);

            if(this.rdbDias.Checked == true)
            {
                fecha = fecha.AddDays(incremento);
            }else if(this.rdbMeses.Checked == true)
            {
                fecha= fecha.AddMonths(incremento);
            }
            else
            {
                fecha = fecha.AddYears(incremento);
            }
            this.txtNF.Text = fecha.ToString();
        }
    }
}
