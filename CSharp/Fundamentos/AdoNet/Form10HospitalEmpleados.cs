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

namespace AdoNet
{
    public partial class Form10HospitalEmpleados : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader reader;

        public Form10HospitalEmpleados()
        {
            InitializeComponent();
            string connectionString =
                @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.cmd = new SqlCommand();
            this.cmd.Connection = this.cn;
            this.LoadHospitales();
        }

        private void LoadHospitales()
        {
            this.cmd.CommandType = CommandType.StoredProcedure;
            this.cmd.CommandText = "SP_HOSPITALES";
            this.cn.Open();
            this.reader = this.cmd.ExecuteReader();
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                this.comboBox1.Items.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = this.comboBox1.SelectedItem.ToString();
            SqlParameter pamnombre = new SqlParameter("@NOMBREHOSPITAL", nombre);
            this.cmd.Parameters.Add(pamnombre);

            SqlParameter pamsuma = new SqlParameter();
            pamsuma.ParameterName = "@SUMA";
            pamsuma.Value = 0;
            pamsuma.Direction = ParameterDirection.Output;
            this.cmd.Parameters.Add(pamsuma);

            SqlParameter pammedia = new SqlParameter();
            pammedia.ParameterName = "@MEDIA";
            pammedia.Value = 0;
            pammedia.Direction = ParameterDirection.Output;
            this.cmd.Parameters.Add(pammedia);

            SqlParameter pampersonas = new SqlParameter();
            pampersonas.ParameterName = "@PERSONAS";
            pampersonas.Value = 0;
            pampersonas.Direction = ParameterDirection.Output;
            this.cmd.Parameters.Add(pampersonas);

            this.cmd.CommandType = CommandType.StoredProcedure;
            this.cmd.CommandText = "SP_EMPLEADOS_HOSPITAL";
            this.cn.Open();
            this.reader = this.cmd.ExecuteReader();
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string ape = this.reader["APELLIDO"].ToString();
                string salario = this.reader["SALARIO"].ToString();
                this.lstEmpleados.Items.Add(ape + " - " + salario);
            }

            this.reader.Close();

            this.textBox1.Text = pamsuma.Value.ToString();
            this.textBox2.Text = pammedia.Value.ToString();
            this.textBox3.Text = pampersonas.Value.ToString();

            this.cmd.Parameters.Clear();
            this.cn.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
