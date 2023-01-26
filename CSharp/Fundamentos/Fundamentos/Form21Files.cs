using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases.Helpers;

namespace Fundamentos
{
    public partial class Form21Files : Form
    {
        
        public Form21Files()
        {
            InitializeComponent();
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            //ES UN OBJETO PARA ABRIR FILES
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                //EL OBJETO FILEINFO ES UN OBJETO PARA 
                //ACCEDER A LA INFORMACION DE UN FICHERO
                string contenido = await HelperFiles.ReadFileAsync(path);
                this.txtContenido.Text = contenido;
                MessageBox.Show("Datos guardados");

                //PARA LEER VAMOS A UTILIZAR using
                //PARA ASEGURARNOS DENTRO DEL CODIGO
                //EL OBJETO SIEMPRE ESTARA ACCESIBLE
                //using (TextReader reader = file.OpenText())
                //{
                //    DENTRO DE ESE CODIGO DEBEMOS UTILIZAR READER
                //    Y DESPUES QUEDARA DESTRUIDO
                //    string contenido = await reader.ReadToEndAsync();
                //    reader.Close();


                //}
            }
        }

        public string GetStringNombres()
        {
            string datos = "";
            foreach (string nombre in this.lstNombres.Items)
            {
                datos += nombre + ",";
            }
            datos = datos.Trim(',');
            return datos;
        }
        //METODO PARA ESCRIBIR LOS NOMBRES QUE
        //TENGAMOS EN UN STRING EN EL LISTBOX
        public void SetStringNombres(string data)
        {
            //ANTONIA, ADRIAN, LUCIA
            string[] nombres = data.Split(',');
            this.lstNombres.Items.Clear();
            foreach(string name in nombres)
            {
                this.lstNombres.Items.Add(name);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtAgregar.Text;
            this.lstNombres.Items.Add(nombre);
            this.txtAgregar.SelectAll();
            this.txtAgregar.Focus();
        }

        private async void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if(save .ShowDialog() == DialogResult.OK)
            {
                string path = save.FileName;
                string contenido = this.GetStringNombres();
                await HelperFiles.WriteFileAsync(path, contenido);
                MessageBox.Show("Datos guardaos");
                //using (TextWriter writer = file.CreateText())
                //{
                //    EL CONTENIDO QUE DESEAMOS ESCRIBIR ESTA EN EL LISTBOX
                //    string contenido = this.GetStringNombres();
                //    await writer.WriteAsync(contenido);
                //    SIEMPRE QUE TRABAJEMOS CON FILES, AL ESCRIBIR
                //    DEBEMOS TERMINAR CON EL METODO FLUSH DESPUES DE ESCRIBIR
                //    await writer.FlushAsync();
                //    writer.Close();
                //}
                //MessageBox.Show("Datos guardados");
            }
        }
    }
}
