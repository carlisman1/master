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
    public partial class Form05DepartamentosEmpleados : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form05DepartamentosEmpleados()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = cn;
            this.LoadDepartamentos();
            
        }

        private void LoadDepartamentos()
        {
            string sql = "select dnombre from dept group by dnombre";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.lstDepartamentos.Items.Clear();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                string nombreDepartamentos = this.reader["dnombre"].ToString();
                this.lstDepartamentos.Items.Add(nombreDepartamentos);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void LoadEmpleados()
        {
            string seleccionado = this.lstDepartamentos.SelectedItem.ToString();
            string sql = "select apellido from emp inner join dept on emp.DEPT_NO = dept.DEPT_NO where dept.DNOMBRE = @seleccionado";
            SqlParameter pamseleccionado = new SqlParameter("@seleccionado", seleccionado);
            this.com.Parameters.Add(pamseleccionado);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEmp.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["apellido"].ToString();
                this.lstEmp.Items.Add(apellido);
            }
            this.cn.Close();
            this.com.Parameters.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadEmpleados();
        }

        private void lstEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string empleado = this.lstEmp.SelectedItem.ToString();
            string sql = "select oficio, salario from emp where apellido = @empleado";
            SqlParameter pamempleado = new SqlParameter("@empleado", empleado);
            this.com.Parameters.Add(pamempleado);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            if (this.reader.Read())
            {
                string oficio = this.reader["oficio"].ToString();
                string salario = this.reader["salario"].ToString();
                this.textBox1.Text = oficio;
                this.textBox2.Text = salario;
            }
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string oficio = this.textBox1.Text;
            int salario = int.Parse(this.textBox2.Text);
            string empleado = this.lstEmp.SelectedItem.ToString();
            string sql = "update emp set OFICIO=@oficio, SALARIO=@salario where emp.apellido = @empleado";
            SqlParameter pamoficio = new SqlParameter("@oficio", oficio);
            SqlParameter pamsueldo = new SqlParameter("@salario", salario);
            SqlParameter pamempleado = new SqlParameter("@empleado", empleado);
            this.com.Parameters.Add(pamoficio);
            this.com.Parameters.Add(pamsueldo);
            this.com.Parameters.Add(pamempleado);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            //CUANDO QUEREMOS ACTUALIZAR PONEMOS ExecuteNonQuery
            int modificados = this.com.ExecuteNonQuery();
            this.cn.Close();
            MessageBox.Show("Enfermos eliminados: " + modificados);
            this.com.Parameters.Clear();
        }
    }
}
