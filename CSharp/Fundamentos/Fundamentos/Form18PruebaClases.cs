using ClassLibrary1;
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
    public partial class Form18PruebaClases : Form
    {
        
        public Form18PruebaClases()
        {
            InitializeComponent();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Alumno";
            persona.Apellidos = "Net Core";
            persona.Edad = 5;
            persona.Nacionalidad = Paises.Italia;
            persona.Genero = TipoGenero.Masculino;
            persona.Domicilio = new Direccion("Calle pez", "Madrid", 28050);

            persona.MetodoParametrosOpcionales(77);
            persona.MetodoParametrosOpcionales(88, 99);

            //SI TUVIESEMOS MAS PARAMETRO OPCIONALES :paramtro
            persona.MetodoParametrosOpcionales(1, numero2: 33);

            //lstDatos.Items.Add(persona.Nombre + " " + persona.Apellidos + " " + persona.Edad);
            lstDatos.Items.Add(persona.GetNombreCompleto());
            lstDatos.Items.Add(persona.Genero + " " + persona.Nacionalidad);
            lstDatos.Items.Add("Direccion: " + persona.Domicilio.Calle);
            lstDatos.Items.Add("Direccion vacaciones: " + persona.DomicilioVacaciones.Calle);
        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Nombre = "Paco";
            empleado.Apellidos = "Empleado";
            this.lstDatos.Items.Add(empleado.GetNombreCompleto() + ", Salario: " + empleado.GetSalarioMinimo());
            this.lstDatos.Items.Add(empleado.GetNombreCompleto() + ", Vacaciones: " + empleado.GetDiasVacaciones());

            Director director = new Director();
            director.Nombre = "Dire";
            director.Apellidos = "Dire";
            this.lstDatos.Items.Add(director.GetNombreCompleto() + ", Salario: " + director.GetSalarioMinimo());
            this.lstDatos.Items.Add(director.GetNombreCompleto() + ", Vacaciones: " + director.GetDiasVacaciones());
        }
    }
}
