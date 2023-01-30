using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNet.Repositories;
using AdoNet.Models;

namespace AdoNet
{
    public partial class Form06AccionDepartamento : Form
    {
        List<Departamento> list;
        RepositoryDepartamentos repo;

        public Form06AccionDepartamento()
        {
            InitializeComponent();
            repo = new RepositoryDepartamentos();
            list = new List<Departamento>();
            this.GetDepa();
        }

        private void GetDepa()
        {
            this.lstDepartamentos.Items.Clear();
            this.list = repo.GetDepartamentos();
            foreach (Departamento dept in list)
            {
                this.lstDepartamentos.Items.Add(dept.Nombre);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.lstDepartamentos.SelectedIndex;
            if(indice != -1)
            {
                this.txtNombre.Text = this.list[indice].Nombre;
                this.txtLocalidad.Text = this.list[indice].Localidad;
                this.txtId.Text = this.list[indice].IdDepartamento.ToString();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            repo.InsertDepartamento(int.Parse(this.txtId.Text),this.txtNombre.Text,this.txtLocalidad.Text);
            this.GetDepa();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            repo.UpdateDepartamento(int.Parse(this.txtId.Text), this.txtNombre.Text, this.txtLocalidad.Text);
            this.GetDepa();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            repo.DeleteDepartamentos(int.Parse(this.txtId.Text));
            this.GetDepa();
        }
    }
}
