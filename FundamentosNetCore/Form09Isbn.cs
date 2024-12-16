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
    public partial class Form09Isbn : Form
    {
        public Form09Isbn()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            int isbn = this.txtTexto.Text.Length;

            if (isbn != 10)
            {
                this.lblResultado.Text = "El ISBN debe contener 10 caracteres";
            }
            else
            {
                string cadena = this.txtTexto.Text;
                int suma = 0;
                for (int i = 0; i < cadena.Length; i++)
                {
                    char caracter = cadena[i];
                    int numero = int.Parse(caracter.ToString());
                    suma += numero * (i + 1);
                }
                if (suma % 11 == 0)
                {
                    this.lblResultado.Text = "El ISBN es correcto";
                }
                else
                {
                    this.lblResultado.Text = "El ISBN no es correcto";
                }
            }
        }
    }
}
