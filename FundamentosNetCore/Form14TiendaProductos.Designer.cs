namespace FundamentosNetCore
{
    partial class Form14TiendaProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtProducto = new TextBox();
            btnNuevo = new Button();
            label2 = new Label();
            lstTienda = new ListBox();
            btnEliminar = new Button();
            btnEliminarTodo = new Button();
            btnSeleccionar = new Button();
            btnTodos = new Button();
            btnBajar = new Button();
            lstAlmacen = new ListBox();
            label3 = new Label();
            btnSubir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 36);
            label1.Name = "label1";
            label1.Size = new Size(97, 19);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(37, 58);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(142, 29);
            txtProducto.TabIndex = 1;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(37, 114);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(142, 30);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 36);
            label2.Name = "label2";
            label2.Size = new Size(75, 19);
            label2.TabIndex = 3;
            label2.Text = "Tienda";
            // 
            // lstTienda
            // 
            lstTienda.FormattingEnabled = true;
            lstTienda.Location = new Point(212, 58);
            lstTienda.Name = "lstTienda";
            lstTienda.Size = new Size(161, 194);
            lstTienda.TabIndex = 4;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(37, 159);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(142, 30);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEliminarTodo
            // 
            btnEliminarTodo.Location = new Point(37, 205);
            btnEliminarTodo.Name = "btnEliminarTodo";
            btnEliminarTodo.Size = new Size(142, 30);
            btnEliminarTodo.TabIndex = 6;
            btnEliminarTodo.Text = "Borrar Todo";
            btnEliminarTodo.UseVisualStyleBackColor = true;
            btnEliminarTodo.Click += btnEliminarTodo_Click;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(373, 96);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(145, 34);
            btnSeleccionar.TabIndex = 7;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(403, 165);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(87, 35);
            btnTodos.TabIndex = 8;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // btnBajar
            // 
            btnBajar.Location = new Point(710, 159);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(114, 30);
            btnBajar.TabIndex = 12;
            btnBajar.Text = "Bajar";
            btnBajar.UseVisualStyleBackColor = true;
            btnBajar.Click += btnBajar_Click;
            // 
            // lstAlmacen
            // 
            lstAlmacen.FormattingEnabled = true;
            lstAlmacen.Location = new Point(519, 58);
            lstAlmacen.Name = "lstAlmacen";
            lstAlmacen.Size = new Size(161, 194);
            lstAlmacen.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(519, 36);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 10;
            label3.Text = "Almacén";
            // 
            // btnSubir
            // 
            btnSubir.Location = new Point(710, 114);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(114, 30);
            btnSubir.TabIndex = 9;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // Form14TiendaProductos
            // 
            AutoScaleDimensions = new SizeF(11F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 327);
            Controls.Add(btnBajar);
            Controls.Add(lstAlmacen);
            Controls.Add(label3);
            Controls.Add(btnSubir);
            Controls.Add(btnTodos);
            Controls.Add(btnSeleccionar);
            Controls.Add(btnEliminarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(lstTienda);
            Controls.Add(label2);
            Controls.Add(btnNuevo);
            Controls.Add(txtProducto);
            Controls.Add(label1);
            Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form14TiendaProductos";
            Text = "Form14TiendaProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProducto;
        private Button btnNuevo;
        private Label label2;
        private ListBox lstTienda;
        private Button btnEliminar;
        private Button btnEliminarTodo;
        private Button btnSeleccionar;
        private Button btnTodos;
        private Button btnBajar;
        private ListBox lstAlmacen;
        private Label label3;
        private Button btnSubir;
    }
}