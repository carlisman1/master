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
    public partial class Form02BuscadorEmpleados : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form02BuscadorEmpleados()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int salario = int.Parse(this.txtSalario.Text);
            string sql = "select * from emp where salario >= " + salario;
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            //SIEMPRE UTILIZAREMOS LO MISMO: ENTRAR Y SALIR
            //ABRIMOS CONEXION
            this.cn.Open();
            //EJECUTAMOS NUESTRA CONSULTA
            this.reader = this.com.ExecuteReader();
            //LEEMOS LOS DATOS
            this.lstSalarios.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string sal = this.reader["SALARIO"].ToString();
                this.lstSalarios.Items.Add(apellido + ", " + sal);
            }
            //SALIMOS
            //CERRAMOS READER Y CONEXION (EL ORDEN NO IMPORTA)
            this.reader.Close();
            this.cn.Close();

        }

        private void txtOficio_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBuscarOficio_Click(object sender, EventArgs e)
        {
            string oficio = (this.txtOficio.Text).ToString();
            string sql = "select * from emp where oficio = '" + oficio + "'";

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstOficio.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string ofi = this.reader["OFICIO"].ToString();
                this.lstOficio.Items.Add(apellido + ", " + ofi);

            }
            this.reader.Close();
            this.cn.Close();
        }
    }
}
