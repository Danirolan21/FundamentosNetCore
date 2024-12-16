namespace FundamentosNetCore
{
    partial class Form09Isbn
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
            btnValidar = new Button();
            label1 = new Label();
            txtTexto = new TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(337, 172);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(262, 59);
            btnValidar.TabIndex = 0;
            btnValidar.Text = "Validar ISBN";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 47);
            label1.Name = "label1";
            label1.Size = new Size(205, 23);
            label1.TabIndex = 1;
            label1.Text = "Introduzca ISBN";
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(194, 86);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(527, 34);
            txtTexto.TabIndex = 2;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(200, 331);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 23);
            lblResultado.TabIndex = 3;
            // 
            // Form09Isbn
            // 
            AutoScaleDimensions = new SizeF(13F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 499);
            Controls.Add(lblResultado);
            Controls.Add(txtTexto);
            Controls.Add(label1);
            Controls.Add(btnValidar);
            Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 3, 5, 3);
            Name = "Form09Isbn";
            Text = "Form09Isbn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnValidar;
        private Label label1;
        private TextBox txtTexto;
        private Label lblResultado;
    }
}