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

            this.BackColor = Color.FromArgb(rojo, verde, azul);
        }
    }
}
