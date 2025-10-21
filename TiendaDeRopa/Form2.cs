using ClasesEjercicioPrueba.Models;
using ClasesModelo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TiendaDeRopa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 nuevaVentana = new Form1();
            nuevaVentana.Show();      // Muestra la nueva ventana
            this.Hide();              // Oculta el formulario actual (opcional)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox4.Text) ||
                comboBox2.SelectedIndex == -1 ||
                string.IsNullOrEmpty(textBox5.Text) ||
                comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Crear el producto con los valores de los TextBox
            int categoriaSeleccionada = (int)comboBox1.SelectedValue;
            

            //  validar que el precio y el stock sean mayores que no se le pueda poner letras
            if (!decimal.TryParse(textBox4.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número válido.");
                return;
            }

            if (decimal.Parse(textBox4.Text) <= 0)
            {
                MessageBox.Show("El precio tiene que ser mayor que 0.");
                return;
            }

            if (!int.TryParse(textBox5.Text, out int stock))
            {
                MessageBox.Show("El stock debe ser un número válido.");
                return;
            }

            if (stock <= 0)
            {
                MessageBox.Show("El stock tiene que ser mayor que 0.");
                return;
            }

            Producto nuevoProducto = new Producto(
                textBox1.Text,          // nombre
                textBox2.Text,          // descripción
                comboBox2.Text,          // talla
                decimal.Parse(textBox4.Text), // precio
                categoriaSeleccionada,  // categoría
                stock                   // stock
            );

            ClasesEjercicioPrueba.Repository.ProductoRepository.GuardarProducto(nuevoProducto);

            textBox1.Clear();
            textBox2.Clear();
            comboBox2.SelectedIndex = -1;
            textBox4.Clear();
            textBox5.Clear();

            MessageBox.Show("Producto guardado correctamente.");


        }

        private void Form2_Load(object sender, EventArgs e)
        {

            var categorias = ClasesEjercicioPrueba.Repository.CategoriaRepository.ObtenerCategorias();

            comboBox2.Items.AddRange(new string[] { "XS", "S", "M", "L", "XL", "XXL" });

            // Carga los datos en el ComboBox
            comboBox1.DataSource = categorias;
            comboBox1.DisplayMember = "Nombre";     // Lo que el usuario ve
            comboBox1.ValueMember = "IdCategoria";  // El valor real que se guarda

            comboBox1.SelectedIndex = -1; // Que no seleccione ninguna al iniciar
            comboBox2.SelectedIndex = -1;
        }
    }
}
