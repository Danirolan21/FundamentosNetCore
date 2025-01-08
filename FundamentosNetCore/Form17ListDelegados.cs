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
    public partial class Form17ListDelegados : Form
    {
        int contador;
        List<Button> botones;
        public Form17ListDelegados()
        {
            InitializeComponent();
            this.contador = 0;
            this.botones = new List<Button>();
            //this.button1.Click += BotonPulsado;
            this.botones.Add(this.button1);
            this.botones.Add(this.button2);
            this.botones.Add(this.button3);
            foreach (Button boton in this.botones)
            {
                boton.Click += BotonPulsado;
            }
        }

        void BotonPulsado(object sender, EventArgs e)
        {
            this.contador++;
            this.txtContador.Text
                        = this.contador.ToString();
            Button miBoton = (Button)sender;
            miBoton.Enabled = false;
        }
    }
}
