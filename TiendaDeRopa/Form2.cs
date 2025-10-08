using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesEjercicioPrueba.Models;
using ClasesModelo.Models;

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
                var nuevoProducto = new Producto(
                    textBox1.Text,  // nombre
                    textBox2.Text,  // descripción
                    textBox3.Text,  // talla
                    decimal.Parse(textBox4.Text), // precio
                    int.Parse(textBox5.Text) // categoría ID
                );

                // Guardarlo en la base
                ClasesEjercicioPrueba.Repository.ProductoRepository.GuardarProducto(nuevoProducto);

                MessageBox.Show("Producto guardado correctamente.");

                // Limpia los campos del formulario
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();

            
        }
    }
}
