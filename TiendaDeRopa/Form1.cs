namespace TiendaDeRopa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 nuevaVentana = new Form2();
            nuevaVentana.Show();      // Muestra la nueva ventana
            this.Hide();              // Oculta el formulario actual (opcional)
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
