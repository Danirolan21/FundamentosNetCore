namespace FundamentosNetCore
{
    partial class Form10Dni
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
            lblResultado = new Label();
            txtTexto = new TextBox();
            label1 = new Label();
            btnValidar = new Button();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(200, 376);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 23);
            lblResultado.TabIndex = 7;
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(194, 131);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(527, 34);
            txtTexto.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 92);
            label1.Name = "label1";
            label1.Size = new Size(192, 23);
            label1.TabIndex = 5;
            label1.Text = "Introduzca DNI";
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(337, 217);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(262, 59);
            btnValidar.TabIndex = 4;
            btnValidar.Text = "Validar DNI";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // Form10Dni
            // 
            AutoScaleDimensions = new SizeF(13F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 516);
            Controls.Add(lblResultado);
            Controls.Add(txtTexto);
            Controls.Add(label1);
            Controls.Add(btnValidar);
            Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 3, 5, 3);
            Name = "Form10Dni";
            Text = "Form10Dni";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private TextBox txtTexto;
        private Label label1;
        private Button btnValidar;
    }
}