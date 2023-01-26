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
using ProyectoClases.Models;

namespace Fundamentos
{
    public partial class Form22Mascotas : Form
    {
        HelperMascotas helper;
        public Form22Mascotas()
        {
            InitializeComponent();
            this.helper = new HelperMascotas();
        }

        private void DibujarMascotas()
        {
            this.listBox1.Items.Clear();
            foreach (Mascota mascota in this.helper.Mascotas)
            {
                this.listBox1.Items.Add(mascota.Nombre);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            this.helper.Mascotas.Add(mascota);
            this.DibujarMascotas();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                await this.helper.ReadFileMascotasAsync(path);
                this.DibujarMascotas();
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                string path = save.FileName;
                await this.helper.SaveFileMascotasAsync(path);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex != -1)
            {
                Mascota mascota = this.helper.Mascotas[this.listBox1.SelectedIndex];
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
            }
        }
    }
}
