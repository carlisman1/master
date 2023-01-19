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
    public partial class Form08ColeccionGrafica : Form
    {
        public Form08ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string elem = this.txtNuevoElemento.Text;
            this.lstElementos.Items.Add(elem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //NECESITAMOS RECUPERAR EL OBJETO SELECCIONADO 
            //CONTROL LISTBOX
            //string seleccionado = this.lstElementos.SelectedItem.ToString()!;
            //this.lstElementos.Items.Remove(seleccionado);
            int indice = this.lstElementos.SelectedIndex;
            this.lstElementos.Items.RemoveAt(indice);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstElementos.SelectedIndex != -1)
            {
                this.lblIndice.Text = this.lstElementos.SelectedIndex.ToString();
                this.lblItem.Text = this.lstElementos.SelectedItem.ToString();
            }
        }
    }
}
