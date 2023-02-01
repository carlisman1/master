using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNet.Repositories;
using AdoNet.Models;

namespace AdoNet
{
    public partial class Form12EmpleadosOficios : Form
    {
        private RepositorioEmpleados RepositorioEmpleados;
        private List<int> IdEmpleados;
        public Form12EmpleadosOficios()
        {
            InitializeComponent();
            RepositorioEmpleados = new RepositorioEmpleados();
            var oficios = this.RepositorioEmpleados.GetOficios();
            this.LoadOficios();
        }

        private void LoadOficios()
        {
            List<string> oficios = this.RepositorioEmpleados.GetOficios();
            foreach (var oficio in oficios)
            {
                this.comboBox1.Items.Add(oficio);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex != -1)
            {
                string nombreOficio = this.comboBox1.SelectedItem.ToString();
                var DatosOficio = RepositorioEmpleados.GetDatosOficio(nombreOficio);
                this.listView1.Items.Clear();
                foreach (var empleado in DatosOficio.Empleados)
                {
                    string apellido = empleado.Apellido;
                    string oficio = empleado.Oficio;
                    string salario = empleado.Salario.ToString();
                    ListViewItem vi = new ListViewItem();
                    vi.Text = apellido; //PRIMERA COLUMNA
                    vi.SubItems.Add(oficio); //SEGUNDA
                    vi.SubItems.Add(salario); //TERCERA
                    vi.SubItems.Add("juancar"); //CUARTA
                    this.listView1.Items.Add(vi);
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ListViewItem viSeleccionado = this.listView1.SelectedItems[0];
            //CUARTA COLUMNA, POSICION 3 DE SUBITEMS
            int item = int.Parse(viSeleccionado.SubItems[3].Text);
            this.RepositorioEmpleados.DeleteEmpleado(item);
        }
    }
}
