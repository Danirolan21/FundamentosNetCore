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
    public partial class Form13ColeccionNumeros : Form
    {
        public Form13ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                Random random = new Random();
                int numero = random.Next(1, 10);
                this.lstNumeros.Items.Add(numero);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            this.txtSuma.Text = "0";
            this.txtSumaPares.Text = "0";
            this.txtSumaImpares.Text = "0";
            for (int i = 0; i < this.lstNumeros.Items.Count; i++)
            {
                int numero = (int) this.lstNumeros.Items[i];
                if (numero % 2 == 0)
                {
                    this.txtSumaPares.Text = (int.Parse(this.txtSumaPares.Text) + numero).ToString();
                }
                else
                {
                    this.txtSumaImpares.Text = (int.Parse(this.txtSumaImpares.Text) + numero).ToString();
                }
                this.txtSuma.Text = (int.Parse(this.txtSuma.Text) + numero).ToString();
            }
        }
    }
}
