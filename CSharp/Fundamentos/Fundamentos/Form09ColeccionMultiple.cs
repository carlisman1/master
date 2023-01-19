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
    public partial class Form09ColeccionMultiple : Form
    {
        public Form09ColeccionMultiple()
        {
            InitializeComponent();
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string elem = this.txtNuevoElemento.Text;
            this.lstElementos.Items.Add(elem);
            this.txtNuevoElemento.Focus();
            this.txtNuevoElemento.SelectAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //NO PODEMOS ELIMINAR ELEMENTOS UTILIZANDO UN BUCLE 
            //REFERENCIA DEBEMOS RECORRER TODOS LOS ELEMENTOS SELECCIONADOS
            //NOS INTERESA EL INDEX DE CADA ELEMENTO NUMERO DE 
            //ELEMENTOS SELECCIONADOS
            int numSeleccionados = this.lstElementos.SelectedIndices.Count;
            //RECORREMOS TODOS LOS INDICES SELECCIONADOS
            for (int i = numSeleccionados-1; i >= 0; i--)
            {
                //RECUPERAMOS EL INDICE SELECCIONADO
                int indice = this.lstElementos.SelectedIndices[i];
                //POR ULTIMO, ELIMINAMOS EL ELEMENTO POR SU INDICE
                this.lstElementos.Items.RemoveAt(indice);
            }
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            //COMO SOLO VAMOS A DIBUJAR, PODEMOS UTILIZAR
            //BUCLES DE REFERENCIA
            string indices = "";
            foreach(int i in this.lstElementos.SelectedIndices)
            {
                indices += indices + ",";
            }
            this.lblIndice.Text = indices.Trim(',');
            string items = "";
            foreach(string elem in this.lstElementos.SelectedItems)
            {
                items += elem + ",";
            }
            this.lstElementos.Items.Clear();
        }
    }
}
