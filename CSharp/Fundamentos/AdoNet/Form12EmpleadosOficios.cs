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
            this.LoadEmpleados();
            this.Get
        }

        private void LoadOficios()
        {
            List<string> oficios = this.RepositorioEmpleados.GetOficios();
            foreach (var oficio in oficios)
            {
                this.comboBox1.Items.Add(oficio);
            }
        }

        private void LoadAllEmpleados()
        {
            
        }

        private void LoadEmpleados()
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
                    int idempleado = empleado.IdEmpleado;
                    ListViewItem vi = new ListViewItem();
                    vi.Text = apellido; //PRIMERA COLUMNA
                    vi.SubItems.Add(oficio); //SEGUNDA
                    vi.SubItems.Add(salario); //TERCERA
                    vi.SubItems.Add(idempleado.ToString()); //CUARTA
                    this.listView1.Items.Add(vi);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadEmpleados();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ListViewItem viSeleccionado = this.listView1.SelectedItems[0];
            //CUARTA COLUMNA, POSICION 3 DE SUBITEMS

            int idEmpleado = int.Parse(viSeleccionado.SubItems[3].Text); //CUARTA COLUMNA
            this.RepositorioEmpleados.DeleteEmpleado(idEmpleado);
            this.LoadEmpleados();
        }
    }
}
