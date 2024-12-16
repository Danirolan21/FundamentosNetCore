namespace FundamentosNetCore
{
    partial class Form12ColeccionMultiple
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
            lblIndexSeleccionado = new Label();
            lblItemSeleccionado = new Label();
            lstElementos = new ListBox();
            label2 = new Label();
            txtNuevoElemento = new TextBox();
            label1 = new Label();
            btnBorrarTodo = new Button();
            btnEliminar = new Button();
            btnInsertar = new Button();
            SuspendLayout();
            // 
            // lblIndexSeleccionado
            // 
            lblIndexSeleccionado.AutoSize = true;
            lblIndexSeleccionado.Location = new Point(69, 399);
            lblIndexSeleccionado.Name = "lblIndexSeleccionado";
            lblIndexSeleccionado.Size = new Size(50, 20);
            lblIndexSeleccionado.TabIndex = 18;
            lblIndexSeleccionado.Text = "label4";
            // 
            // lblItemSeleccionado
            // 
            lblItemSeleccionado.AutoSize = true;
            lblItemSeleccionado.Location = new Point(69, 351);
            lblItemSeleccionado.Name = "lblItemSeleccionado";
            lblItemSeleccionado.Size = new Size(50, 20);
            lblItemSeleccionado.TabIndex = 17;
            lblItemSeleccionado.Text = "label3";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(69, 70);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(275, 244);
            lstElementos.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 31);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 15;
            label2.Text = "Elementos:";
            // 
            // txtNuevoElemento
            // 
            txtNuevoElemento.Location = new Point(470, 70);
            txtNuevoElemento.Name = "txtNuevoElemento";
            txtNuevoElemento.Size = new Size(262, 27);
            txtNuevoElemento.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(469, 31);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 13;
            label1.Text = "Nuevo elemento";
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(468, 288);
            btnBorrarTodo.Margin = new Padding(5, 3, 5, 3);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(169, 53);
            btnBorrarTodo.TabIndex = 12;
            btnBorrarTodo.Text = "Borrar Todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = Color.IndianRed;
            btnEliminar.Location = new Point(468, 216);
            btnEliminar.Margin = new Padding(5, 3, 5, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(169, 53);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(468, 146);
            btnInsertar.Margin = new Padding(5, 3, 5, 3);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(169, 53);
            btnInsertar.TabIndex = 10;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            // 
            // Form12ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIndexSeleccionado);
            Controls.Add(lblItemSeleccionado);
            Controls.Add(lstElementos);
            Controls.Add(label2);
            Controls.Add(txtNuevoElemento);
            Controls.Add(label1);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Name = "Form12ColeccionMultiple";
            Text = "Form12ColeccionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIndexSeleccionado;
        private Label lblItemSeleccionado;
        private ListBox lstElementos;
        private Label label2;
        private TextBox txtNuevoElemento;
        private Label label1;
        private Button btnBorrarTodo;
        private Button btnEliminar;
        private Button btnInsertar;
    }
}