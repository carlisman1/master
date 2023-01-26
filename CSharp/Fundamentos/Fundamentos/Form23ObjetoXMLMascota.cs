using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases.Models;
using System.IO;
using System.Xml.Serialization;

namespace Fundamentos
{
    public partial class Form23ObjetoXMLMascota : Form
    {
        //EL OBJETO PARA SERIALIZAR EN XML
        XmlSerializer serializer;
        public Form23ObjetoXMLMascota()
        {
            InitializeComponent();
            //EN EL MOMENTO DE INSTANCIAR EL OBJETO
            //SERA NECESARIO INDICAR LA CLASE QUE UTILIZARA
            //EN LA SERIALIZACION
            this.serializer = new XmlSerializer(typeof(Mascota));
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //LEER ES IGUAL SOLO QUE UTILIZA UN OBJETO LLAMADO
            //StreamReader
            Mascota mascota = null;
            using (StreamReader reader = new StreamReader("C:/Users/Alumnos MCSD Mañana/Documents/mascotas.xml"))
            {
                //NCESITAMOS RECUPERAR EL OBJETO MASCOTA
                //MEDIANTE EL SERIALIZADOR TIENE UN METODO
                //LAMADO Deserialize QUE RECUPERA EL OBJETO
                //SERIALIZADO
                mascota = (Mascota)this.serializer.Deserialize(reader);
                reader.Close();
            }
            this.txtNombre.Text = mascota.Nombre;
            this.txtRaza.Text = mascota.Raza;
            this.txtAños.Text = mascota.Years.ToString();

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Years = int.Parse(this.txtAños.Text);
            //PARA SERIALIZAR SE UTILIZA EL OBJETO DE System.IO
            //NO IMPORTA LA EXTENSION DEL ARCHIVO, SIEMPRE LO
            //ALMACENA CON FORMATO XML
            using (StreamWriter writer = new StreamWriter("C:/Users/Alumnos MCSD Mañana/Documents/mascotas.xml"))
            {
                //EL SERIALIZADOR XML TIENE UN METODO LLAMADO
                //Serialize() QUE UTILIZA EL FICHERO PARA GUARDAR EL OBJETO
                this.serializer.Serialize(writer, mascota);
                //COMO HABLAMOS DE FICHEROS Y ESCRITURA
                //DEBEMOS UTILIZAR Flush()
                await writer.FlushAsync();
                writer.Close();
            }
            this.txtAños.Text = "";
            this.txtNombre.Text = "";
            this.txtRaza.Text = "";

        }
    }
}
