namespace FundamentosNetCore
{
    partial class Form15Metodos
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
            lblResultado = new Label();
            txtNumero = new TextBox();
            btnDobleValor = new Button();
            btnDobleReferencia = new Button();
            btnObjetoReferencia = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 63);
            label1.Name = "label1";
            label1.Size = new Size(75, 19);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(119, 186);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(141, 19);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "lblResultado";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(119, 85);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(128, 29);
            txtNumero.TabIndex = 2;
            // 
            // btnDobleValor
            // 
            btnDobleValor.Location = new Point(432, 88);
            btnDobleValor.Name = "btnDobleValor";
            btnDobleValor.Size = new Size(207, 62);
            btnDobleValor.TabIndex = 3;
            btnDobleValor.Text = "Doble Valor";
            btnDobleValor.UseVisualStyleBackColor = true;
            btnDobleValor.Click += btnDobleValor_Click;
            // 
            // btnDobleReferencia
            // 
            btnDobleReferencia.Location = new Point(432, 176);
            btnDobleReferencia.Name = "btnDobleReferencia";
            btnDobleReferencia.Size = new Size(207, 62);
            btnDobleReferencia.TabIndex = 4;
            btnDobleReferencia.Text = "Doble Referencia";
            btnDobleReferencia.UseVisualStyleBackColor = true;
            btnDobleReferencia.Click += btnDobleReferencia_Click;
            // 
            // btnObjetoReferencia
            // 
            btnObjetoReferencia.Location = new Point(431, 268);
            btnObjetoReferencia.Name = "btnObjetoReferencia";
            btnObjetoReferencia.Size = new Size(208, 86);
            btnObjetoReferencia.TabIndex = 5;
            btnObjetoReferencia.Text = "Objeto Referencia";
            btnObjetoReferencia.UseVisualStyleBackColor = true;
            btnObjetoReferencia.Click += btnObjetoReferencia_Click;
            // 
            // Form15Metodos
            // 
            AutoScaleDimensions = new SizeF(11F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 619);
            Controls.Add(btnObjetoReferencia);
            Controls.Add(btnDobleReferencia);
            Controls.Add(btnDobleValor);
            Controls.Add(txtNumero);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form15Metodos";
            Text = "Form15Metodos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResultado;
        private TextBox txtNumero;
        private Button btnDobleValor;
        private Button btnDobleReferencia;
        private Button btnObjetoReferencia;
    }
}