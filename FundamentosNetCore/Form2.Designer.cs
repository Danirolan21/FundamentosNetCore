namespace FundamentosNetCore
{
    partial class Form01SumarNumeros
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
            txtNum1 = new TextBox();
            label2 = new Label();
            txtNum2 = new TextBox();
            lblResultado = new Label();
            btnSumar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(457, 68);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Número 1";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(457, 105);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(125, 27);
            txtNum1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(457, 165);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Número 2";
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(457, 199);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(125, 27);
            txtNum2.TabIndex = 3;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(493, 302);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 20);
            lblResultado.TabIndex = 4;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(128, 174);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(199, 76);
            btnSumar.TabIndex = 5;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // Form01SumarNumeros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSumar);
            Controls.Add(lblResultado);
            Controls.Add(txtNum2);
            Controls.Add(label2);
            Controls.Add(txtNum1);
            Controls.Add(label1);
            Name = "Form01SumarNumeros";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNum1;
        private Label label2;
        private TextBox txtNum2;
        private Label lblResultado;
        private Button btnSumar;
    }
}