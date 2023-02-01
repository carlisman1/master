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
    public partial class Form11HospitalesEmpledosClases : Form
    {
        private RepositorioHospital RepositorioHospital;
        
        public Form11HospitalesEmpledosClases()
        {
            InitializeComponent();
            RepositorioHospital = new RepositorioHospital();
            var hospitales = this.RepositorioHospital.GetHospitales();
            
            this.LoadHospitales();
        }

        private void LoadHospitales()
        {
            List<string> hospitales = this.RepositorioHospital.GetHospitales();
            foreach (var hospital in hospitales)
            {
                this.comboBox1.Items.Add(hospital);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.comboBox1.SelectedIndex != -1)
            {
                string nombreHospital = this.comboBox1.SelectedItem.ToString();
                DatosHospital datos = this.RepositorioHospital.GetDatosHospital(nombreHospital);
                this.lstEmpleados.Items.Clear();
                foreach (var EmpleadoHospital in datos.Empleados)
                {
                    this.lstEmpleados.Items.Add(EmpleadoHospital.Apellido + " - " +
                        EmpleadoHospital.Salario);
                }
                this.textBox1.Text = datos.SumaSalarial.ToString();
                this.textBox2.Text = datos.MediaSalarial.ToString();
                this.textBox3.Text = datos.Personas.ToString();
            }
            
        }
    }
}
