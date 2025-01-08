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
    public partial class Form18SumarBotones : Form
    {
        List<Button> botones;
        int suma;
        public Form18SumarBotones()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            this.suma = 0;
            this.txtSuma.Enabled = false;
            //ALMACENAMOS TODOS LOS CONTROLES DEL PANEL
            //DENTRO DE NUESTRA COLECCION DE BOTONES
            foreach (Button boton in this.panel1.Controls)
            {
                this.botones.Add(boton);
                boton.Click += SumarNumeros;
            }
        }

        void SumarNumeros(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            int numero = int.Parse(boton.Text);
            this.suma += numero;
            this.txtSuma.Text = suma.ToString();
        }
        private void btnIniciarApp_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.suma = 0;
            this.txtSuma.Text = suma.ToString();
            //RECORREMOS TODOS LOS BOTONES DE MI COLECCION
            foreach (Button boton in this.botones)
            {
                //ASIGNAMOS UN NUMERO ALEATORIO ENTRE 1 Y 99
                int numero = random.Next(1, 99);
                //ASIGNAMOS EL NUMERO AL TEXTO DEL BOTON
                boton.Text = numero.ToString();
            }
        }
    }
}
