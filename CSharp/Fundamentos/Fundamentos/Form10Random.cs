using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form10Random : Form
    {
        public Form10Random()
        {
            InitializeComponent();
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int valor = random.Next(1, 20);
            this.lstElementos.Items.Add(valor);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int count = this.lstElementos.Items.Count;
            int counSelecc = this.lstElementos.SelectedItems.Count;
            int suma = 0;
            int sumaPares = 0;
            int sumaImpares = 0;
            int sumaSelecc = 0;

            for(int i = 0; i < count; i++)
            {
                suma=suma+int.Parse(this.lstElementos.Items[i].ToString()!);
                txtSuma.Text = suma.ToString();
                if (int.Parse(this.lstElementos.Items[i].ToString()!) % 2 == 0)
                {
                    sumaPares = sumaPares + int.Parse(this.lstElementos.Items[i].ToString()!);
                    txtPares.Text = sumaPares.ToString();
                }
                else
                {
                    sumaImpares = sumaImpares + int.Parse(this.lstElementos.Items[i].ToString()!);
                    txtImpares.Text = sumaImpares.ToString();
                }
                
            }
            for(int i = 0; i < counSelecc; i++)
            {
                sumaSelecc = sumaSelecc + int.Parse(this.lstElementos.SelectedItems[i].ToString()!);
                txtSelecc.Text = sumaSelecc.ToString();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
