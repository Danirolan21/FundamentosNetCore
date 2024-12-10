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
    public partial class Form01SumarNumeros : System.Windows.Forms.Form
    {
        public Form01SumarNumeros()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToInt32(txtNum1.Text);
            var num2 = Convert.ToInt32(txtNum2.Text);
            var resultado = num1 + num2;
            lblResultado.Text = resultado.ToString();
        }
    }
}
