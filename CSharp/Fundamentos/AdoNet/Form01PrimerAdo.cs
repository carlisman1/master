using System.Data;
using System.Data.SqlClient;

namespace AdoNet
{
    public partial class Form01PrimerAdo : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form01PrimerAdo()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            this.cn.StateChange += Cn_StateChange;

        }
        private void Cn_StateChange(object sender, StateChangeEventArgs e)
        {
            this.lblMensaje.Text = "La conexion esta cambiando de "
                + e.OriginalState + " a " + e.CurrentState;
        }

        private void lstTiposDato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cn.State == ConnectionState.Closed)
                {
                    this.cn.Open();
                };
                this.lblMensaje.BackColor = Color.LightGreen;
            }
            catch(Exception ex)
            {
                this.lblMensaje.Text = "Error en la bbdd "+ex;
            }
            
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                string dato = "aaaa";
                int numero1 = 6;
                int numero2 = 0;
                int division = numero1 / numero2;
            }
            catch(Exception ex)
            {
                this.lblMensaje.Text = "Error en el programa " + ex;
            }

            this.cn.Close();
            this.lblMensaje.BackColor = Color.LightCoral;

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM EMP";
                //INDICAMOS AL COMANDO LA CONEXION A UTILIAR
                this.com.Connection = this.cn;
                //INDICAMOS EL TIPO DE CONSULTA
                this.com.CommandType = CommandType.Text;
                //INDICAMOS LA CONSULTA
                this.com.CommandText = sql;

                //CON TODO CONFIGURADO, PARA EJECUTAR LA CONSULTA
                //DEBEMOS TENER UNA CONEXION ABIERTA
                //EJECUTAMOS LA CONSULTA Y EXTRAEMOS EL READER
                this.reader = this.com.ExecuteReader();
                for (int i = 0; i < this.reader.FieldCount; i++)
                {
                    string columna = this.reader.GetName(i);
                    this.lstColumnas.Items.Add(columna);
                }
                //DIBUJAMOS LA PRIMERA COLUMNA DE LA TABLA

                //DIBUJAMOS EL TIPO DE LA PRIMERA COLUMNA DE LA TABLA
                string tipo = this.reader.GetDataTypeName(0);
                this.lstTiposDato.Items.Add(tipo);
                //VAMOS A RECUPERAR UN APELLIDO
                while (this.reader.Read())
                {
                    string apellido = this.reader["APELLIDO"].ToString();
                    this.lstApellidos.Items.Add(apellido);
                }
                this.reader.Close();
                
            }
            catch(Exception ex)
            {
                this.lblMensaje.Text = "Error de leer datos " + ex;
            }  
        }
    }
}