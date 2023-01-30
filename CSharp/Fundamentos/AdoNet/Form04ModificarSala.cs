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
    public partial class Form04ModificarSala : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form04ModificarSala()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = cn;
            this.LoadSalas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreNuevo = this.textBox1.Text;
            string nombreSala = this.listBox1.SelectedItem.ToString();
            string sql = "update sala set nombre = @nombreNuevo where sala.nombre = @nombreSala";
            SqlParameter pamNuevo = new SqlParameter("@nombreNuevo", nombreNuevo);
            SqlParameter pamSala = new SqlParameter("@nombreSala", nombreSala);
            this.com.Parameters.Add(pamNuevo);
            this.com.Parameters.Add(pamSala);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int modificados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            MessageBox.Show("Enfermos eliminados: " + modificados);
            this.LoadSalas();
        }

        private void LoadSalas()
        {
            string sql = "select nombre from sala group by nombre";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.listBox1.Items.Clear();
            while (this.reader.Read())
            {
                string nombreSalas = this.reader["nombre"].ToString();
                this.listBox1.Items.Add(nombreSalas);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
