namespace FundamentosNetCore
{
    partial class Form11ColeccionGrafica
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
            btnInsertar = new Button();
            btnEliminar = new Button();
            btnBorrarTodo = new Button();
            label1 = new Label();
            txtNuevoElemento = new TextBox();
            label2 = new Label();
            lstElementos = new ListBox();
            lblItemSeleccionado = new Label();
            lblIndexSeleccionado = new Label();
            SuspendLayout();
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(464, 140);
            btnInsertar.Margin = new Padding(5, 3, 5, 3);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(169, 53);
            btnInsertar.TabIndex = 0;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(464, 210);
            btnEliminar.Margin = new Padding(5, 3, 5, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(169, 53);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(464, 282);
            btnBorrarTodo.Margin = new Padding(5, 3, 5, 3);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(169, 53);
            btnBorrarTodo.TabIndex = 2;
            btnBorrarTodo.Text = "Borrar Todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(465, 25);
            label1.Name = "label1";
            label1.Size = new Size(192, 23);
            label1.TabIndex = 3;
            label1.Text = "Nuevo elemento";
            // 
            // txtNuevoElemento
            // 
            txtNuevoElemento.Location = new Point(466, 64);
            txtNuevoElemento.Name = "txtNuevoElemento";
            txtNuevoElemento.Size = new Size(262, 34);
            txtNuevoElemento.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 25);
            label2.Name = "label2";
            label2.Size = new Size(140, 23);
            label2.TabIndex = 6;
            label2.Text = "Elementos:";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(65, 64);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(275, 257);
            lstElementos.TabIndex = 7;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // lblItemSeleccionado
            // 
            lblItemSeleccionado.AutoSize = true;
            lblItemSeleccionado.Location = new Point(65, 345);
            lblItemSeleccionado.Name = "lblItemSeleccionado";
            lblItemSeleccionado.Size = new Size(88, 23);
            lblItemSeleccionado.TabIndex = 8;
            lblItemSeleccionado.Text = "label3";
            // 
            // lblIndexSeleccionado
            // 
            lblIndexSeleccionado.AutoSize = true;
            lblIndexSeleccionado.Location = new Point(65, 393);
            lblIndexSeleccionado.Name = "lblIndexSeleccionado";
            lblIndexSeleccionado.Size = new Size(88, 23);
            lblIndexSeleccionado.TabIndex = 9;
            lblIndexSeleccionado.Text = "label4";
            // 
            // Form11ColeccionGrafica
            // 
            AutoScaleDimensions = new SizeF(13F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 496);
            Controls.Add(lblIndexSeleccionado);
            Controls.Add(lblItemSeleccionado);
            Controls.Add(lstElementos);
            Controls.Add(label2);
            Controls.Add(txtNuevoElemento);
            Controls.Add(label1);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 3, 5, 3);
            Name = "Form11ColeccionGrafica";
            Text = "Form11ColeccionGrafica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnBorrarTodo;
        private Label label1;
        private TextBox txtNuevoElemento;
        private Label label2;
        private ListBox lstElementos;
        private Label lblItemSeleccionado;
        private Label lblIndexSeleccionado;
    }
}