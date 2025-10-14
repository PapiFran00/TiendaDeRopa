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

            Form2 AgregarRopa = new Form2();
            AgregarRopa.Show();      // Muestra la nueva ventana
            this.Hide();              // Oculta el formulario actual (opcional)
        }

        private void label1_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.Show();      // Muestra la nueva ventana
            this.Hide();              // Oculta el formulario actual (opcional)

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 nuevaVenta = new Form3();
            nuevaVenta.Show();      // Muestra la nueva ventana
            this.Hide();              // Oculta el formulario actual (opcional)
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 nuevoCliente = new Form4();
            nuevoCliente.Show();      // Muestra la nueva ventana
            this.Hide();              // Oculta el formulario actual (opcional)
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 verClientes = new Form5();
            verClientes.Show();      // Muestra la nueva ventana
            this.Hide();              // Oculta el formulario actual (opcional)

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form6 nuevaVenta = new Form6();
            nuevaVenta.Show();      // Muestra la nueva ventana
            this.Hide();              // Oculta el formulario actual (opcional)


        }
    }
}
