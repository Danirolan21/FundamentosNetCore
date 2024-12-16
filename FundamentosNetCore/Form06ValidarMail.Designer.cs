namespace FundamentosNetCore
{
    partial class Form06ValidarMail
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
            btnComprobarMail = new Button();
            txtMail = new TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 81);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(286, 32);
            label1.TabIndex = 0;
            label1.Text = "Introduzca un Mail Valido";
            // 
            // btnComprobarMail
            // 
            btnComprobarMail.Location = new Point(189, 214);
            btnComprobarMail.Name = "btnComprobarMail";
            btnComprobarMail.Size = new Size(223, 50);
            btnComprobarMail.TabIndex = 1;
            btnComprobarMail.Text = "Comprobar";
            btnComprobarMail.UseVisualStyleBackColor = true;
            btnComprobarMail.Click += btnComprobarMail_Click;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(162, 132);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(278, 39);
            txtMail.TabIndex = 2;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(154, 318);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(144, 32);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "lblResultado";
            // 
            // Form06ValidarMail
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 433);
            Controls.Add(lblResultado);
            Controls.Add(txtMail);
            Controls.Add(btnComprobarMail);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form06ValidarMail";
            Text = "Form06ValidarMail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnComprobarMail;
        private TextBox txtMail;
        private Label lblResultado;
    }
}