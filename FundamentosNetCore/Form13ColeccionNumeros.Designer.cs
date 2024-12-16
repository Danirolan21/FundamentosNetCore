namespace FundamentosNetCore
{
    partial class Form13ColeccionNumeros
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
            lstNumeros = new ListBox();
            label1 = new Label();
            btnGenerar = new Button();
            btnMostrarDatos = new Button();
            label2 = new Label();
            txtSuma = new TextBox();
            txtSumaPares = new TextBox();
            label3 = new Label();
            txtSumaImpares = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Location = new Point(59, 96);
            lstNumeros.Margin = new Padding(5, 4, 5, 4);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(179, 251);
            lstNumeros.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 64);
            label1.Name = "label1";
            label1.Size = new Size(86, 19);
            label1.TabIndex = 1;
            label1.Text = "Números";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(384, 50);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(204, 49);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(384, 116);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(204, 49);
            btnMostrarDatos.TabIndex = 3;
            btnMostrarDatos.Text = "Mostrar datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 196);
            label2.Name = "label2";
            label2.Size = new Size(53, 19);
            label2.TabIndex = 4;
            label2.Text = "Suma";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(448, 193);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(165, 29);
            txtSuma.TabIndex = 5;
            // 
            // txtSumaPares
            // 
            txtSumaPares.Location = new Point(448, 252);
            txtSumaPares.Name = "txtSumaPares";
            txtSumaPares.Size = new Size(165, 29);
            txtSumaPares.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(356, 255);
            label3.Name = "label3";
            label3.Size = new Size(64, 19);
            label3.TabIndex = 6;
            label3.Text = "Pares";
            // 
            // txtSumaImpares
            // 
            txtSumaImpares.Location = new Point(448, 318);
            txtSumaImpares.Name = "txtSumaImpares";
            txtSumaImpares.Size = new Size(165, 29);
            txtSumaImpares.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(356, 321);
            label4.Name = "label4";
            label4.Size = new Size(86, 19);
            label4.TabIndex = 8;
            label4.Text = "Impares";
            // 
            // Form13ColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(11F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 530);
            Controls.Add(txtSumaImpares);
            Controls.Add(label4);
            Controls.Add(txtSumaPares);
            Controls.Add(label3);
            Controls.Add(txtSuma);
            Controls.Add(label2);
            Controls.Add(btnMostrarDatos);
            Controls.Add(btnGenerar);
            Controls.Add(label1);
            Controls.Add(lstNumeros);
            Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form13ColeccionNumeros";
            Text = "Form13ColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstNumeros;
        private Label label1;
        private Button btnGenerar;
        private Button btnMostrarDatos;
        private Label label2;
        private TextBox txtSuma;
        private TextBox txtSumaPares;
        private Label label3;
        private TextBox txtSumaImpares;
        private Label label4;
    }
}