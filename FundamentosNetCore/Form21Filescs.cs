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
    public partial class Form21Filescs : Form
    {
        private string Path { get; set; }
        public Form21Filescs()
        {
            InitializeComponent();
            //CUANDO HABLAMOS DE RUTAS DE FICHEROS, CON CARACTERES
            //ESPECIALES: \ TENEMOS DOS POSIBILIDADES
            //C:\carpeta
            this.Path = "file1.txt";
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(txtNombre.Text);
            this.txtNombre.Text = "";
        }
        public string GetNombreListBox()
        {
            string data = "";
            foreach (string name in this.lstNombres.Items)
            {
                data += name + ",";
            }
            data = data.Trim(',');
            return data;
        }

        private async void btnWriteFile_Click(object sender, EventArgs e)
        {
            //TENEMOS UNA CLASE LLAMADA FileInfo NOS DEVUELVE UN FILE
            //Y PODEMOS GENERAR WRITER O READER
            FileInfo file = new FileInfo(this.Path);
            //CREAMOS EL FICHERO
            using (TextWriter writer = file.CreateText())
            {
                //RECUPERAMOS LOS NOMBRES DEL LISTBOX
                string contenido = this.GetNombreListBox();
                //ESCRIBIMOS DENTRO DEL FICHERO
                await writer.WriteAsync(contenido);
                //DESPUES DE ESCRIBIR EN CUALQUIER FICHERO
                //SE DEBE APLICAR EL METODO Flush()
                await writer.FlushAsync();
                //CERRAMOS EL FICHERO
                writer.Close();
                MessageBox.Show("Datos almacenados");
            }
        }

        private async void btnReadFile_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(this.Path);
            using (TextReader reader = file.OpenText())
            {
                string contenido = await reader.ReadToEndAsync();
                this.txtContenidoFile.Text = contenido;
                reader.Close();
                this.RellenarListBox(contenido);
            }
        }

        public void RellenarListBox(string nombres)
        {
            string[] data = nombres.Split(',');
            this.lstNombres.Items.Clear();
            foreach (string name in data)
            {
                this.lstNombres.Items.Add(name);
            }
        }
    }
}
