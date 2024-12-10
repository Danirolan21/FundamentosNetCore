namespace FundamentosNetCore
{
    partial class Form02PosicionColores
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtPosicionX = new TextBox();
            txtPosicionY = new TextBox();
            txtRojo = new TextBox();
            txtVerde = new TextBox();
            txtAzul = new TextBox();
            btnCambiarPosicion = new Button();
            btnCambiarColor = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(415, 72);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 0;
            label1.Text = "Rojo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(415, 157);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 1;
            label2.Text = "Verde";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(415, 228);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 2;
            label3.Text = "Azul";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 69);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 3;
            label4.Text = "Posición X:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 148);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 4;
            label5.Text = "Posición Y:";
            // 
            // txtPosicionX
            // 
            txtPosicionX.Location = new Point(168, 66);
            txtPosicionX.Name = "txtPosicionX";
            txtPosicionX.Size = new Size(125, 27);
            txtPosicionX.TabIndex = 5;
            // 
            // txtPosicionY
            // 
            txtPosicionY.Location = new Point(168, 145);
            txtPosicionY.Name = "txtPosicionY";
            txtPosicionY.Size = new Size(125, 27);
            txtPosicionY.TabIndex = 6;
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(487, 66);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(125, 27);
            txtRojo.TabIndex = 7;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(487, 154);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(125, 27);
            txtVerde.TabIndex = 8;
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(487, 225);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(125, 27);
            txtAzul.TabIndex = 9;
            // 
            // btnCambiarPosicion
            // 
            btnCambiarPosicion.Location = new Point(78, 202);
            btnCambiarPosicion.Name = "btnCambiarPosicion";
            btnCambiarPosicion.Size = new Size(172, 50);
            btnCambiarPosicion.TabIndex = 10;
            btnCambiarPosicion.Text = "Cambiar Posición";
            btnCambiarPosicion.UseVisualStyleBackColor = true;
            btnCambiarPosicion.Click += btnCambiarPosicion_Click;
            // 
            // btnCambiarColor
            // 
            btnCambiarColor.Location = new Point(415, 292);
            btnCambiarColor.Name = "btnCambiarColor";
            btnCambiarColor.Size = new Size(203, 48);
            btnCambiarColor.TabIndex = 11;
            btnCambiarColor.Text = "Cambiar Color";
            btnCambiarColor.UseVisualStyleBackColor = true;
            btnCambiarColor.Click += btnCambiarColor_Click;
            // 
            // Form02PosicionColores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCambiarColor);
            Controls.Add(btnCambiarPosicion);
            Controls.Add(txtAzul);
            Controls.Add(txtVerde);
            Controls.Add(txtRojo);
            Controls.Add(txtPosicionY);
            Controls.Add(txtPosicionX);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form02PosicionColores";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtPosicionX;
        private TextBox txtPosicionY;
        private TextBox txtRojo;
        private TextBox txtVerde;
        private TextBox txtAzul;
        private Button btnCambiarPosicion;
        private Button btnCambiarColor;
    }
}