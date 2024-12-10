namespace FundamentosNetCore
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Fundamentos .NET Core";
            this.SuspendLayout();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Location = new Point(104, 67);
            this.txtNombre.Text = "Hola Mundo";
            this.txtNombre.Width = 125;
            this.txtNombre.TextAlign = HorizontalAlignment.Center;
        }
    }
}
