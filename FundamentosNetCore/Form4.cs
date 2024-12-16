using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(txtDia.Text);
            int mes = int.Parse(txtMes.Text);
            int anio = int.Parse(txtAnio.Text);

            if (mes == 1)
            {
                mes = 13;
                anio -= 1;
            }
            else if (mes == 2)
            {
                mes = 14;
                anio--;
            }

            int operacion1 = ((mes + 1) * 3) / 5;
            int operacion2 = anio / 4;
            int operacion3 = anio / 100;
            int operacion4 = anio / 400;
            int operacion5 = dia + (mes * 2) + anio + operacion1 + operacion2 - operacion3 + operacion4 + 2;
            int operacion6 = operacion5 / 7;
            int diaSemana = operacion5 - (operacion6 * 7);
            Array diasSemana = new string[] { "Sábado", "Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
            this.lblDiaSemana.Text = diasSemana.GetValue(diaSemana).ToString();
        }
    }
}
