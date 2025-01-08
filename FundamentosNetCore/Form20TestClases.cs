using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace FundamentosNetCore
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Juan";
            persona.Apellidos = "Perez";
            persona.Edad = 22;
            persona.Genero = TipoGenero.Masculino;

            this.lstClases.Items.Add("Indizada " + persona[0]);
            this.lstClases.Items.Add("Indizada " + persona[0]);

            persona.Nacionalidad = Paises.España;

            persona.Domicilio.Calle = "Calle Mayor";
            persona.Domicilio.Ciudad = "Madrid";
            persona.Domicilio.CodigoPostal = 28080;
            this.lstClases.Items.Add(
                "Direccion: " + persona.Domicilio.Calle + ", " + persona.Domicilio.Ciudad);

            this.lstClases.Items.Add(persona.GetNombreCompleto());
            this.lstClases.Items.Add("Edad: " + persona.Edad);
            this.lstClases.Items.Add("Genero: " + persona.Genero + ", Nacionalidad: " + persona.Nacionalidad);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            //Empleado empleado = new Empleado("Empleado", "Empleado");
            Empleado empleado = new Empleado();
            empleado.Nombre = "Empleado";
            empleado.Apellidos = "Empleado";

            this.lstClases.Items.Add(empleado.GetNombreCompleto());
            this.lstClases.Items.Add("Vacaciones empleado: " 
                + empleado.GetDiasVacaciones());
            this.lstClases.Items.Add("Salario empleado: " 
                + empleado.GetSalarioMinimo());

            Director director = new Director();
            director.Nombre = "Director";
            director.Apellidos = "Director";
            this.lstClases.Items.Add(director.GetNombreCompleto());
            this.lstClases.Items.Add("Vacaciones director: "
                + director.GetDiasVacaciones());
            this.lstClases.Items.Add("Salario director: "
                + director.GetSalarioMinimo());
        }
    }
}
