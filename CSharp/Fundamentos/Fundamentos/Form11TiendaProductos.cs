using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form11TiendaProductos : Form
    {
        public Form11TiendaProductos()
        {
            Stopwatch krono;
            


            InitializeComponent();
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void MetodoInsert()
        {
            string elem = this.txtProd.Text;
            this.lstTienda.Items.Add(elem);
            this.txtProd.Focus();
            this.txtProd.SelectAll();

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            MetodoInsert();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //NO PODEMOS ELIMINAR ELEMENTOS UTILIZANDO UN BUCLE 
            //REFERENCIA DEBEMOS RECORRER TODOS LOS ELEMENTOS SELECCIONADOS
            //NOS INTERESA EL INDEX DE CADA ELEMENTO NUMERO DE 
            //ELEMENTOS SELECCIONADOS
            int count = this.lstTienda.SelectedIndices.Count;
            //RECORREMOS TODOS LOS INDICES SELECCIONADOS
            for (int i= count-1 ; i >= 0 ; i--)
            {
                //NECESITAMOS RECUPERAR EL ITEM SELECCIONADO
                int indiceSeleccionado = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(indiceSeleccionado);
            }
        }

        private void lstTienda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int count = this.lstTienda.SelectedIndices.Count;
            //RECORREMOS TODOS LOS INDICES SELECCIONADOS
            for (int i = count - 1; i >= 0; i--)
            {
                //NECESITAMOS RECUPERAR EL ITEM SELECCIONADO
                int indiceSeleccionado = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items[indiceSeleccionado] = this.txtProd.Text;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            int count = this.lstTienda.SelectedIndices.Count;
            for(int i = count - 1; i >= 0; i--)
            {
                string itemSelecc = this.lstTienda.SelectedItems[i].ToString()!;
                int indiceSeleccionado = this.lstTienda.SelectedIndices[i];
                this.lstAlmacen.Items.Add(itemSelecc);
                this.lstTienda.Items.RemoveAt(indiceSeleccionado);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            //int numero = this.lstTienda.Items.Count;
            //for (int i = 0; i <= numero; i++)
            //{
            //    this.lstAlmacen.Items.Add(this.lstTienda.Items[0]);
            //    this.lstTienda.Items.RemoveAt(0);
            //}
            int items = this.lstTienda.Items.Count;
            for (int i = items - 1; i >= 0; i--)
            {
                this.lstAlmacen.Items.Add(this.lstTienda.Items[0]);
                this.lstTienda.Items.RemoveAt(0);
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado = this.lstAlmacen.SelectedIndex;
            string producto = this.lstAlmacen.SelectedItem.ToString()!;
            //EL ORDEN DE LOS FACTORES ALTERA EL PRODUCTO
            //1
            this.lstAlmacen.Items.RemoveAt(indiceSeleccionado);
            //2
            this.lstAlmacen.Items.Insert(indiceSeleccionado - 1,producto);
            this.lstAlmacen.SelectedIndex = indiceSeleccionado - 1;


            
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int indice = this.lstAlmacen.SelectedIndex;
            string producto = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(indice);
            this.lstAlmacen.Items.Insert(indice + 1, producto);
            this.lstAlmacen.SelectedIndex = indice + 1;
        }

        
        private void txtProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaEnter = (char)Keys.Enter;
            if (e.KeyChar == teclaEnter)
            {
                MetodoInsert();
            }
        }
    }
}
