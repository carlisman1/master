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
    public partial class Form03EliminarEnfermo : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form03EliminarEnfermo()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = cn;
            this.LoadEnfermo();
        }

        private void LoadEnfermo()
        {
            string sql = "select * from enfermo";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.listBox1.Items.Clear();
            while (this.reader.Read())
            {
                string inscripcion = this.reader["INSCRIPCION"].ToString();
                string apellido = this.reader["APELLIDO"].ToString();
                this.listBox1.Items.Add(inscripcion + ", " + apellido);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int inscripcion = int.Parse(this.textBox1.Text);
            string sql = "delete from enfermo where inscripcion = @inscripcion";
            //CREAMOS UN NUEVO OBJETO PARAMETER
            SqlParameter paminscripcion = new SqlParameter("@inscripcion", inscripcion);
            this.com.Parameters.Add(paminscripcion);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText= sql;
            this.cn.Open();
            int eliminados = this.com.ExecuteNonQuery();
            this.cn.Close();
            MessageBox.Show("Enfermos eliminados: " + eliminados);
            this.LoadEnfermo();
        }
    }
}
