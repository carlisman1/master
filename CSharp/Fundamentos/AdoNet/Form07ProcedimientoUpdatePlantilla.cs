using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

#region PROCEDIMIENTOS ALMACENADOS
#endregion

/*
    Procedure del ejercicio para actualizar el salario de un hospital si supera el millon

CREATE PROCEDURE SP_HOSPITALES
AS
    SELECT * FROM HOSPITAL;
GO CREATE PROCEDURE SP_UPDATESALARIOSHOSPITAL
(@NOMBRE NVARCHAR(50))
AS
 DECLARE @SUELDO_TOTAL INT
    DECLARE @HOSPITALCOD INT     SELECT @HOSPITALCOD = HOSPITAL_COD FROM HOSPITAL WHERE NOMBRE = 'La Paz';
SELECT* FROM PLANTILLA WHERE HOSPITAL_COD = @HOSPITALCOD; SELECT @SUELDO_TOTAL = SUM(CAST(SALARIO AS int)) FROM PLANTILLA
    WHERE NOMRE = @NOMBRE; IF(@SUELDO_TOTAL > 1000000) BEGIN
 UPDATE PLANTILLA SET SALARIO = SALARIO - 10000 WHERE HOSPITAL_COD = @HOSPITALCOD;
PRINT 'DISMINUCION SALARIO EN 10000'

 END
 ELSE BEGIN
        UPDATE PLANTILLA SET SALARIO = SALARIO + 10000 WHERE HOSPITAL_COD = @HOSPITALCOD;
PRINT 'AUMENTO SALARIO EN 10000'

 END
GO EXEC SP_HOSPITALES;
*/

namespace AdoNet
{
    public partial class Form07ProcedimientoUpdatePlantilla : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader reader;

        public Form07ProcedimientoUpdatePlantilla()
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
            this.comboBox1.Items.Clear();
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = this.comboBox1.SelectedItem.ToString();
            SqlParameter pamnombre = new SqlParameter("@NOMBRE", nombre);
            this.cmd.Parameters.Add(pamnombre);
            this.cmd.CommandType = CommandType.StoredProcedure;
            this.cmd.CommandText = "SP_UPDATESALARIOSHOSPITAL";
            this.cn.Open();
            this.reader = this.cmd.ExecuteReader();
            this.lstPlantilla.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string funcion = this.reader["FUNCION"].ToString();
                string salario = this.reader["SALARIO"].ToString();
                this.lstPlantilla.Items.Add(apellido + ", " + funcion + ", " + salario);
            }
            this.reader.Close();
            this.cn.Close();
            this.cmd.Parameters.Clear();
        }
    }
}