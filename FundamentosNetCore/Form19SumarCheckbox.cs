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
    public partial class Form19SumarCheckbox : Form
    {
        int suma;
        List<CheckBox> checks;
        public Form19SumarCheckbox()
        {
            InitializeComponent();
            this.suma = 0;
            this.checks = new List<CheckBox>();
            foreach (CheckBox check in this.panel1.Controls)
            {
                this.checks.Add(check);
                check.CheckedChanged += SumarChecks;
            }
        }

        void SumarChecks(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            int numero = int.Parse(check.Text);
            if (check.Checked)
            {
                this.suma += numero;
            }
            else
            {
                this.suma -= numero;
            }
            this.txtSuma.Text = this.suma.ToString();
        }

        private void btnIniciarApp_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.suma = 0;
            this.txtSuma.Text = this.suma.ToString();
            this.checks.Clear();
            foreach (CheckBox check in this.panel1.Controls.OfType<CheckBox>())
            {
                int numero = random.Next(1, 99);
                check.Text = numero.ToString();
                check.Checked = false;
                this.checks.Add(check);
            }
        }
    }
}
