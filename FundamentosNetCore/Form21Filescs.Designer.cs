namespace FundamentosNetCore
{
    partial class Form21Filescs
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
            btnNombre = new Button();
            btnReadFile = new Button();
            btnWriteFile = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            txtContenidoFile = new TextBox();
            label2 = new Label();
            lstNombres = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnNombre
            // 
            btnNombre.Location = new Point(430, 130);
            btnNombre.Margin = new Padding(4, 3, 4, 3);
            btnNombre.Name = "btnNombre";
            btnNombre.Size = new Size(128, 60);
            btnNombre.TabIndex = 0;
            btnNombre.Text = "Nuevo nombre";
            btnNombre.UseVisualStyleBackColor = true;
            btnNombre.Click += btnNombre_Click;
            // 
            // btnReadFile
            // 
            btnReadFile.Location = new Point(430, 229);
            btnReadFile.Margin = new Padding(4, 3, 4, 3);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(128, 46);
            btnReadFile.TabIndex = 1;
            btnReadFile.Text = "Read File";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // btnWriteFile
            // 
            btnWriteFile.Location = new Point(430, 281);
            btnWriteFile.Margin = new Padding(4, 3, 4, 3);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(128, 46);
            btnWriteFile.TabIndex = 2;
            btnWriteFile.Text = "Write File";
            btnWriteFile.UseVisualStyleBackColor = true;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(430, 36);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(431, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(127, 30);
            txtNombre.TabIndex = 4;
            // 
            // txtContenidoFile
            // 
            txtContenidoFile.Location = new Point(39, 50);
            txtContenidoFile.Multiline = true;
            txtContenidoFile.Name = "txtContenidoFile";
            txtContenidoFile.Size = new Size(314, 364);
            txtContenidoFile.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 20);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 6;
            label2.Text = "Contenido File";
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.Location = new Point(640, 50);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(248, 364);
            lstNombres.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(640, 20);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 8;
            label3.Text = "Nombres";
            // 
            // Form21Filescs
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 449);
            Controls.Add(label3);
            Controls.Add(lstNombres);
            Controls.Add(label2);
            Controls.Add(txtContenidoFile);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnWriteFile);
            Controls.Add(btnReadFile);
            Controls.Add(btnNombre);
            Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form21Filescs";
            Text = "Form21Filescs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNombre;
        private Button btnReadFile;
        private Button btnWriteFile;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtContenidoFile;
        private Label label2;
        private ListBox lstNombres;
        private Label label3;
    }
}