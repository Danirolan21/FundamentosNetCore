namespace FundamentosNetCore
{
    partial class Form03DiaNacimiento
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
            btnCalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAnio = new TextBox();
            lblDiaSemana = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 16F);
            btnCalcular.Location = new Point(350, 40);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(256, 148);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular día nacimiento";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 40);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 1;
            label1.Text = "Día";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 130);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 2;
            label2.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 218);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 3;
            label3.Text = "Año";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(54, 72);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(125, 27);
            txtDia.TabIndex = 4;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(54, 161);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(125, 27);
            txtMes.TabIndex = 5;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(54, 255);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(125, 27);
            txtAnio.TabIndex = 6;
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.Font = new Font("Segoe UI", 14F);
            lblDiaSemana.Location = new Point(350, 255);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new Size(160, 32);
            lblDiaSemana.TabIndex = 7;
            lblDiaSemana.Text = "lblDiaSemana";
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDiaSemana);
            Controls.Add(txtAnio);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Name = "Form03DiaNacimiento";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAnio;
        private Label lblDiaSemana;
    }
}