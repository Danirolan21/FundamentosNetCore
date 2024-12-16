namespace FundamentosNetCore
{
    partial class Form08StringBuilder
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
            txtTexto = new RichTextBox();
            label1 = new Label();
            lblTiempo = new Label();
            btnString = new Button();
            btnStringBuilder = new Button();
            SuspendLayout();
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(55, 65);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(716, 279);
            txtTexto.TabIndex = 0;
            txtTexto.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 30);
            label1.Name = "label1";
            label1.Size = new Size(303, 32);
            label1.TabIndex = 1;
            label1.Text = "Copie el texto para trabajar";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTiempo.Location = new Point(55, 354);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(221, 31);
            lblTiempo.TabIndex = 2;
            lblTiempo.Text = "Tiempo del proceso";
            // 
            // btnString
            // 
            btnString.Location = new Point(55, 396);
            btnString.Name = "btnString";
            btnString.Size = new Size(289, 55);
            btnString.TabIndex = 3;
            btnString.Text = "Invertir String";
            btnString.UseVisualStyleBackColor = true;
            btnString.Click += btnString_Click;
            // 
            // btnStringBuilder
            // 
            btnStringBuilder.Location = new Point(482, 396);
            btnStringBuilder.Name = "btnStringBuilder";
            btnStringBuilder.Size = new Size(289, 55);
            btnStringBuilder.TabIndex = 5;
            btnStringBuilder.Text = "Invertir con StringBuilder";
            btnStringBuilder.UseVisualStyleBackColor = true;
            btnStringBuilder.Click += btnStringBuilder_Click;
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 479);
            Controls.Add(btnStringBuilder);
            Controls.Add(btnString);
            Controls.Add(lblTiempo);
            Controls.Add(label1);
            Controls.Add(txtTexto);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "Form08StringBuilder";
            Text = "Form08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtTexto;
        private Label label1;
        private Label lblTiempo;
        private Button btnString;
        private Button btnStringBuilder;
    }
}