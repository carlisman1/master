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
    public partial class Form16TablaMultipicar : Form
    {
        List<TextBox> texts;
        int mult = 0;
        public Form16TablaMultipicar()
        {
            InitializeComponent();
            this.texts = new List<TextBox>();

            foreach(Control control in groupBox1.Controls)
            {
                if (control is TextBox)
                {
                    this.texts.Add((TextBox)control);
                }
            }
            this.texts.Reverse();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = texts.Count - 1; i >= 0; i--)
            {
                int num = int.Parse(this.txtNumero.Text);
                int multi = (num * (i+1));
                this.texts[i].Text = multi.ToString();
            }
        }
    }
}
