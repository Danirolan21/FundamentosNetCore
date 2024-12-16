namespace FundamentosNetCore
{
    partial class Form04DateTime
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
            chkCambiarFormato = new CheckBox();
            label1 = new Label();
            txtFechaActual = new TextBox();
            rdbDias = new RadioButton();
            rdbMeses = new RadioButton();
            btnIncrementar = new Button();
            groupBox1 = new GroupBox();
            txtIncrementar = new TextBox();
            rdbAnios = new RadioButton();
            label2 = new Label();
            txtNuevaFecha = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // chkCambiarFormato
            // 
            chkCambiarFormato.AutoSize = true;
            chkCambiarFormato.Location = new Point(71, 129);
            chkCambiarFormato.Name = "chkCambiarFormato";
            chkCambiarFormato.Size = new Size(185, 24);
            chkCambiarFormato.TabIndex = 0;
            chkCambiarFormato.Text = "Cambiar formato fecha";
            chkCambiarFormato.UseVisualStyleBackColor = true;
            chkCambiarFormato.CheckedChanged += chkCambiarFormato_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 57);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 1;
            label1.Text = "Fecha Actual";
            // 
            // txtFechaActual
            // 
            txtFechaActual.Location = new Point(71, 80);
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.Size = new Size(336, 27);
            txtFechaActual.TabIndex = 2;
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(43, 43);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(59, 24);
            rdbDias.TabIndex = 3;
            rdbDias.TabStop = true;
            rdbDias.Text = "Días";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.Location = new Point(43, 83);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(71, 24);
            rdbMeses.TabIndex = 4;
            rdbMeses.TabStop = true;
            rdbMeses.Text = "Meses";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(300, 107);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(147, 36);
            btnIncrementar.TabIndex = 7;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtIncrementar);
            groupBox1.Controls.Add(rdbAnios);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rdbDias);
            groupBox1.Controls.Add(btnIncrementar);
            groupBox1.Controls.Add(rdbMeses);
            groupBox1.Location = new Point(71, 169);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(514, 188);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtIncrementar
            // 
            txtIncrementar.Location = new Point(300, 68);
            txtIncrementar.Name = "txtIncrementar";
            txtIncrementar.Size = new Size(147, 27);
            txtIncrementar.TabIndex = 10;
            // 
            // rdbAnios
            // 
            rdbAnios.AutoSize = true;
            rdbAnios.Location = new Point(43, 119);
            rdbAnios.Name = "rdbAnios";
            rdbAnios.Size = new Size(63, 24);
            rdbAnios.TabIndex = 9;
            rdbAnios.TabStop = true;
            rdbAnios.Text = "Años";
            rdbAnios.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 45);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 8;
            label2.Text = "Incrementar";
            // 
            // txtNuevaFecha
            // 
            txtNuevaFecha.Location = new Point(71, 421);
            txtNuevaFecha.Name = "txtNuevaFecha";
            txtNuevaFecha.Size = new Size(336, 27);
            txtNuevaFecha.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 398);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 10;
            label3.Text = "Nueva Fecha";
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 513);
            Controls.Add(label3);
            Controls.Add(txtNuevaFecha);
            Controls.Add(groupBox1);
            Controls.Add(txtFechaActual);
            Controls.Add(label1);
            Controls.Add(chkCambiarFormato);
            Name = "Form04DateTime";
            Text = "Form5";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkCambiarFormato;
        private Label label1;
        private TextBox txtFechaActual;
        private RadioButton rdbDias;
        private RadioButton rdbMeses;
        private Button btnIncrementar;
        private GroupBox groupBox1;
        private TextBox txtIncrementar;
        private RadioButton rdbAnios;
        private Label label2;
        private TextBox txtNuevaFecha;
        private Label label3;
    }
}