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
    public partial class Form06Email : Form
    {
        public Form06Email()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String email = this.txtEmail.Text.ToString();            

            if (email.Contains("@")==true)
            {
                email.Trim(' ');
                email.Trim('@');
                if (email.IndexOf('@') == email.LastIndexOf('@')){
                    if (email.IndexOf('.') != -1)
                    {
                        if (email.IndexOf("@") < email.IndexOf("."))
                        {
                            int ultimoPunto = email.LastIndexOf(".");
                            string dominio = email.Substring(ultimoPunto + 1);
                            if(dominio.Length >= 2 && dominio.Length <= 4)
                            {
                                this.lblRes.Text = "EMAIL CORRECTO!!!";
                            }
                            else
                            {
                                this.lblRes.Text = "dominio incorrecto";
                            }
                        }
                        else
                        {
                            this.lblRes.Text = "El email esta mal escrito, el punto va despues del @";
                        }
                    }
                    else
                    {
                        this.lblRes.Text = "El email no tiene .";
                    }
                }
                else
                {
                    this.lblRes.Text = "El email tiene mas de una @";
                }
            }
            else
            {
                this.lblRes.Text = "El email no contiene @ ";
            }
        }
    }
}
