using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using ProyectoClases.Models;
using ProyectoClases.Helpers;

namespace Fundamentos
{
    public partial class Form24ColeccionXml : Form
    {
        XmlSerializer serializer;
        List<Mascota> coleccionMascotas;

        public Form24ColeccionXml()
        {
            InitializeComponent();
            this.coleccionMascotas = new();
            serializer = new(typeof(List<Mascota>));
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Years = int.Parse(this.txtAños.Text);
            mascota.Imagen = HelperFiles.saveImage("C:\\Users\\Alumnos MCSD Mañana\\Downloads\\perrete.jpg");
            //PARA PINTAR NECESITAMOS LA CLASE IMAGE: Image.FromStream(stream);
            
            this.coleccionMascotas.Add(mascota);
            this.txtNombre.Text = "";
            this.txtRaza.Text = "";
            this.txtAños.Text = "";

        }
        private void DibujarMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in this.coleccionMascotas)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("coleccionmascotas.xml"))
            {
                this.coleccionMascotas = (List<Mascota>)this.serializer.Deserialize(reader);
                reader.Close();
            }
            this.DibujarMascotas();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("coleccionmascotas.xml"))
            {
                {
                    this.serializer.Serialize(writer, this.coleccionMascotas);
                    await writer.FlushAsync();
                    writer.Close();
                }
                this.lstMascotas.Items.Clear();
                this.coleccionMascotas.Clear();
            }
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.lstMascotas.SelectedIndex;
            if(indice == -1)
            {
                Mascota mascota = this.coleccionMascotas[indice];
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
                this.txtAños.Text = mascota.Years.ToString();
                
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                var imagen = HelperFiles.saveImage(path);
                MemoryStream ms = new MemoryStream(imagen);
                this.pictureBox1.Image = Image.FromStream(ms);

            }
        }
    }
}
