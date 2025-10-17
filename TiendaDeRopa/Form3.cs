using ClasesEjercicioPrueba.Models;
using ClasesEjercicioPrueba.Repository;
using ClasesModelo.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TiendaDeRopa
{
    public partial class Form3 : Form
    {
        private Producto codigoAactualizar; // Variable para almacenar el producto actual
        public Form3()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();      // Muestra la nueva ventana
            this.Hide();              // Oculta el formulario actual (opcional)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Buscar ropa por codigo
            int codigoBuscado = int.Parse(textBox1.Text);
            codigoAactualizar = ProductoRepository.ObtenerProductoPorCodigo(codigoBuscado);

            if (codigoAactualizar != null)
            {
                
                textBox1.Text = codigoAactualizar.IdProducto.ToString();
                textBox2.Text = codigoAactualizar.Nombre;
                textBox3.Text = codigoAactualizar.Descripcion;
                comboBox2.SelectedValue = codigoAactualizar.Talla.ToString();
                textBox5.Text = codigoAactualizar.Precio.ToString();
                comboBox1.SelectedValue = codigoAactualizar.CategoriaId;
                textBox6.Text = codigoAactualizar.Stock.ToString();

            }
            else
            {
                MessageBox.Show("Producto no encontrado");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int codigoAactualizar = int.Parse(textBox1.Text);
            //guardar cambios en el producto
            if (string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                comboBox2.SelectedIndex == -1 ||
                string.IsNullOrEmpty(textBox5.Text) ||
                string.IsNullOrEmpty(textBox6.Text) ||
                comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (decimal.Parse(textBox5.Text) <= 0)
            {
                MessageBox.Show("El precio tiene que ser mayor que 0.");
                return;
            }

            if (int.Parse(textBox6.Text) <= 0)
            {
                MessageBox.Show("El stock tiene que ser mayor que 0.");
                return;
            }
                       
                

            if (this.codigoAactualizar != null)
            {

                this.codigoAactualizar.IdProducto = int.Parse(textBox1.Text);
                this.codigoAactualizar.Nombre = textBox2.Text;
                this.codigoAactualizar.Descripcion = textBox3.Text;
                this.codigoAactualizar.Precio = decimal.Parse(textBox5.Text);
                this.codigoAactualizar.CategoriaId = int.Parse(comboBox1.SelectedValue.ToString());
                this.codigoAactualizar.Stock = int.Parse(textBox6.Text);
                this.codigoAactualizar.Talla = comboBox2.SelectedItem.ToString();

                ProductoRepository.ActualizarProducto(this.codigoAactualizar);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox2.SelectedIndex = -1;
                textBox5.Clear();
                textBox6.Clear();
                comboBox1.SelectedIndex = -1;
                MessageBox.Show("Cambios guardados correctamente");
                
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Eliminar producto
            int codigoAEliminar = int.Parse(textBox1.Text);

            // Muestra un mensaje de confirmación
            var resultado = MessageBox.Show("Seguro que quiere eliminar el producto.", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox2.SelectedIndex = -1;
                textBox5.Clear();
                textBox6.Clear();
                comboBox1.SelectedIndex = -1;

                ProductoRepository.EliminarProducto(codigoAEliminar);
                MessageBox.Show("Producto eliminado correctamente.");
            }
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var categorias = ClasesEjercicioPrueba.Repository.CategoriaRepository.ObtenerCategorias();
            var talla = ClasesEjercicioPrueba.Repository.CategoriaRepository.ObtenerCategorias();


            comboBox2.Items.AddRange(new string[] { "XS", "S", "M", "L", "XL", "XXL" });
        

       
            comboBox1.DataSource = categorias;
            comboBox1.DisplayMember = "Nombre";     
            comboBox1.ValueMember = "IdCategoria";  

            comboBox1.SelectedIndex = -1; // Que no seleccione ninguna al iniciar
            comboBox2.SelectedIndex = -1; 

        }
    }
}
