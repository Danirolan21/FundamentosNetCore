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
    public partial class Form02PosicionColores : System.Windows.Forms.Form
    {
        public Form02PosicionColores()
        {
            InitializeComponent();
        }

        private void btnCambiarPosicion_Click(object sender, EventArgs e)
        {
            var posicionX = int.Parse(txtPosicionX.Text);
            var posicionY = int.Parse(txtPosicionY.Text);
            this.btnCambiarPosicion.Location = new Point(posicionX, posicionY);
        }

        private void btnCambiarColor_Click(object sender, EventArgs e)
        {
            var rojo = int.Parse(txtRojo.Text);
            var verde = int.Parse(txtVerde.Text);
            var azul = int.Parse(txtAzul.Text);

            if (rojo < 0 || rojo > 255)
            {
                MessageBox.Show("El valor de rojo debe estar entre 0 y 255",
                    "Titulo",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Question);
            }
            else if (verde < 0 || verde > 255)
            {
                MessageBox.Show("El valor de verde debe estar entre 0 y 255",
                    "Titulo",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Question);
            }
            else if (azul < 0 || azul > 255)
            {
                MessageBox.Show("El valor de azul debe estar entre 0 y 255",
                    "Titulo",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Question);
            }
            else
            {
                this.BackColor = Color.FromArgb(rojo, verde, azul);
            }
        }
    }
}
