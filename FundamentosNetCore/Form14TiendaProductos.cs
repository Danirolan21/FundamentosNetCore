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
    public partial class Form14TiendaProductos : Form
    {
        public Form14TiendaProductos()
        {
            InitializeComponent();
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;
            this.lstTienda.Items.Add("LECHE");
            this.lstTienda.Items.Add("PAN");
            this.lstTienda.Items.Add("HUEVOS");
            this.lstAlmacen.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string producto = this.txtProducto.Text.ToUpper();
            if (!String.IsNullOrEmpty(this.txtProducto.Text))
            {
                if (this.lstTienda.Items.Contains(producto))
                {
                    MessageBox.Show("El producto ya existe en la tienda");
                    this.lstTienda.SelectedItem = producto;
                }
                else
                {
                    this.lstTienda.Items.Add(producto);
                    this.txtProducto.Text = "";
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Remove(this.lstTienda.SelectedItem);
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            foreach (var item in this.lstTienda.SelectedItems)
            {
                this.lstAlmacen.Items.Add(item);
            }
            foreach (var item in this.lstAlmacen.Items)
            {
                this.lstTienda.Items.Remove(item);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            foreach (var item in this.lstTienda.Items)
            {
                this.lstAlmacen.Items.Add(item);
            }
            this.lstTienda.Items.Clear();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            if (this.lstAlmacen.SelectedIndex > 0)
            {
                int index = this.lstAlmacen.SelectedIndex;
                object item = this.lstAlmacen.SelectedItem;
                this.lstAlmacen.Items.RemoveAt(index);
                this.lstAlmacen.Items.Insert(index - 1, item);
                this.lstAlmacen.SelectedIndex = index - 1;
            }
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            if (this.lstAlmacen.SelectedIndex < this.lstAlmacen.Items.Count - 1)
            {
                int index = this.lstAlmacen.SelectedIndex;
                object item = this.lstAlmacen.SelectedItem;
                this.lstAlmacen.Items.RemoveAt(index);
                this.lstAlmacen.Items.Insert(index + 1, item);
                this.lstAlmacen.SelectedIndex = index + 1;
            }
        }
    }
}
