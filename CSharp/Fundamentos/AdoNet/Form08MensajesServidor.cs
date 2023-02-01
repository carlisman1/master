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

#region PROCEDIMIENTOS ALMACENADOS
//ALTER PROCEDURE SP_INSERT_DEPARTAMENTO
//(@DEPT_NO INT, @DNOMBRE NVARCHAR(50),
//@LOC NVARCHAR(50))
//AS
//    IF(@LOC = 'TERUEL')BEGIN
//        PRINT 'TERUEL NO EXISTE'
//	END
//	ELSE
//	BEGIN
//		INSERT INTO DEPT VALUES (@DEPT_NO, @DNOMBRE, @LOC)
//	END

//GO

//ALTER PROCEDURE SP_DEPARTAMENTOS
//AS
//    SELECT * FROM DEPT
//GO
#endregion

namespace AdoNet
{
    public partial class Form08MensajesServidor : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader reader;

        public Form08MensajesServidor()
        {
            InitializeComponent();
            string connectionString =
                @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.cmd = new SqlCommand();
            this.cmd.Connection = this.cn;
            this.cn.InfoMessage += Cn_InfoMessage;
            this.LoadDepartamentos();
        }

        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            this.lblMs.Text = e.Message;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.lblMs.Text = "";

            int deptnum = int.Parse(this.textBox1.Text);
            string nombre = this.textBox2.Text;
            string loc = this.textBox3.Text;
            SqlParameter pamnum = new SqlParameter("@DEPT_NO", deptnum);
            SqlParameter pamnombre = new SqlParameter("@DNOMBRE", nombre);
            SqlParameter pamloc = new SqlParameter("@LOC", loc);
            this.cmd.Parameters.Add(pamnum);
            this.cmd.Parameters.Add(pamnombre);
            this.cmd.Parameters.Add(pamloc);    
            this.cmd.CommandType = CommandType.StoredProcedure;
            this.cmd.CommandText = "SP_INSERT_DEPARTAMENTO";
            this.cn.Open();
            int afectados = this.cmd.ExecuteNonQuery();
            this.lstDepartamentos.Items.Clear();
            this.cn.Close();
            MessageBox.Show("Se ha insertado el departamento: " + nombre);
            this.cmd.Parameters.Clear();

            this.LoadDepartamentos();
        }

        private void LoadDepartamentos()
        {
            this.cmd.CommandType = CommandType.StoredProcedure;
            this.cmd.CommandText = "SP_DEPARTAMENTOS";
            this.cn.Open();
            this.reader = this.cmd.ExecuteReader();
            this.lstDepartamentos.Items.Clear();
            while (this.reader.Read())
            {
                int deptnum = int.Parse(this.reader["DEPT_NO"].ToString());
                string nombre = this.reader["DNOMBRE"].ToString();
                string loc = this.reader["LOC"].ToString();
                this.lstDepartamentos.Items.Add(deptnum + ", " + nombre + ", " + loc);
            }
            this.cn.Close();
            this.reader.Close();
        }

        private void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
