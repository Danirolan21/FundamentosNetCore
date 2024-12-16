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
    public partial class Form06ValidarMail : Form
    {
        public Form06ValidarMail()
        {
            InitializeComponent();
        }

        private void btnComprobarMail_Click(object sender, EventArgs e)
        {
            var email = this.txtMail.Text;
            var aroba = email.IndexOf("@");
            var punto = email.LastIndexOf(".");
            var dominio = email.Substring(punto + 1);

            if (email.Contains("@") && email.Contains("."))
            {
                if (email.IndexOf("@") == 0 || email.EndsWith("@"))
                {
                    this.lblResultado.Text = "El email contiene un @ al inicio o al final";
                }
                else if (aroba < punto)
                {
                    if (dominio.Length < 2 || dominio.Length > 4)
                    {
                        this.lblResultado.Text = "El dominio no es correcto";
                    }
                    else
                    {
                        this.lblResultado.Text = "El email es correcto";
                    }
                }
                else
                {
                    this.lblResultado.Text = "Debe haber un punto despues del @";
                }
            }
            else if (!email.Contains("@"))
            {
                this.lblResultado.Text = "Falta el @";
            }
            else if (!email.Contains("."))
            {
                this.lblResultado.Text = "Falta el punto";
            }
            else
            {
                this.lblResultado.Text = "El email no es correcto";
            }

        }
    }
}
