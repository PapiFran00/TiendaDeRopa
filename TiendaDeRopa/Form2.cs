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


            // Crear el producto con los valores de los TextBox
            int categoriaSeleccionada = (int)comboBox1.SelectedValue;
            int stock = int.Parse(textBox5.Text);

            Producto nuevoProducto = new Producto(
                textBox1.Text,          // nombre
                textBox2.Text,          // descripción
                textBox3.Text,          // talla
                decimal.Parse(textBox4.Text), // precio
                categoriaSeleccionada,  // categoría
                stock                   // stock
            );

            ClasesEjercicioPrueba.Repository.ProductoRepository.GuardarProducto(nuevoProducto);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            MessageBox.Show("Producto guardado correctamente.");


        }

        private void Form2_Load(object sender, EventArgs e)
        {

            var categorias = ClasesEjercicioPrueba.Repository.CategoriaRepository.ObtenerCategorias();

            // Carga los datos en el ComboBox
            comboBox1.DataSource = categorias;
            comboBox1.DisplayMember = "Nombre";     // Lo que el usuario ve
            comboBox1.ValueMember = "IdCategoria";  // El valor real que se guarda

            comboBox1.SelectedIndex = -1; // Que no seleccione ninguna al iniciar
            
        }
    }
}
