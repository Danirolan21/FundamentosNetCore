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
    public partial class Form10Dni : Form
    {
        public Form10Dni()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string dni = this.txtTexto.Text;
            if (dni.Length != 9)
            {
                this.lblResultado.Text = "El DNI debe contener 9 caracteres";
            }
            else
            {
                string numeros = dni.Substring(0, 8);
                string letra = dni.Substring(8).ToUpper();
                int numero = int.Parse(numeros);
                char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
                int operacion = numero - (numero / 23) * 23;
                if (letra == letras[operacion].ToString())
                {
                    this.lblResultado.Text = "El DNI es correcto";
                }
                else
                {
                    this.lblResultado.Text = "El DNI no es correcto, su letra es " + letras[operacion].ToString();
                }
            }
        }
    }
}
