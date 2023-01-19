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
    public partial class Form03CaclularDia : Form
    {
        public Form03CaclularDia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string[] diaSemana = new string[] { "sabado", "domingo", "lunes", "martes", "miercoles", "jueves", "viernes" };

            int dia = int.Parse(this.txtDia.Text);
            int mes = int.Parse(this.txtMes.Text);
            int año = int.Parse(this.txtAño.Text);

            if(mes == 1)
            {
                mes = 13;
                año -= 1;
            }else if(mes == 2)
            {
                mes = 14;
                año -= 1;
            }

            int op1 = ((mes + 1) * 3) / 5; 
            int op2 = año / 4;
            int op3 = año / 100;
            int op4 = año / 400;
            int op5 = dia + (mes * 2) + año + op1 + op2 - op3 + op4 + 2;
            int op6 = op5 / 7;
            int op7 = op5 - (op6 * 7);

            string  diaFinal = diaSemana[op7];
            this.lblDia.Text = diaFinal;

        }
    }
}
