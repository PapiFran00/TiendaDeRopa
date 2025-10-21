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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TiendaDeRopa
{
    public partial class Form6 : Form
    {
        public Form6()
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

            int dniBuscado = int.Parse(textBox1.Text);
            Cliente cliente = ClienteRepository.ObtenerClientePorDni(dniBuscado);
            if (cliente != null)
            {
                // Mostrar los datos del cliente en los TextBox correspondientes
                int.TryParse(textBox2.Text, out int idCliente);
                textBox2.Text = cliente.IdCliente.ToString();
                textBox3.Text = cliente.Nombre;
                textBox4.Text = cliente.Apellido;


            }
            else
            {
                MessageBox.Show("Cliente no encontrado");
            }



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            int codigoBuscado = int.Parse(textBox5.Text);
            Producto producto = ProductoRepository.ObtenerProductoPorCodigo(codigoBuscado);

            if (producto != null)
            {

                textBox5.Text = producto.IdProducto.ToString();
                textBox6.Text = producto.Nombre;
                textBox7.Text = producto.Descripcion;
                textBox8.Text = producto.Precio.ToString();

            }
            else
            {
                MessageBox.Show("Producto no encontrado");
            }



        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) ||
               string.IsNullOrEmpty(textBox5.Text) ||
               comboBox1.SelectedIndex == -1 ||
               string.IsNullOrEmpty(textBox9.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!textBox1.Text.All(char.IsDigit))
            {
                MessageBox.Show("El DNI del cliente solo debe contener números.");
                return;
            }
            

            if (!textBox5.Text.All(char.IsDigit))
            {
                MessageBox.Show("El ID del producto solo debe contener números.");
                return;
            }

            if (!textBox9.Text.All(char.IsDigit))
            {
                MessageBox.Show("La cantidad solo debe contener números.");
                return;
            }

            // Guardar el pedido en la base de datos
            int idCliente = int.Parse(textBox2.Text);
            int idProducto = int.Parse(textBox5.Text);
            int cantidad = int.Parse(textBox9.Text);
            DateTime fechaPedido = dateTimePicker1.Value;
            string talla = comboBox1.SelectedItem.ToString();
            decimal precioUnitario = decimal.Parse(textBox8.Text);
            decimal total = precioUnitario * cantidad;

            if(cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que cero.");
                return;
            }
            DetallePedido nuevoPedido = new DetallePedido
            {
                FechaPedido = fechaPedido,
                IdCliente = idCliente,
                IdProducto = idProducto,
                Cantidad = cantidad,
                Talla = talla,
                PrecioUnitario = precioUnitario,
                Total = total
            };

            Producto producto = ProductoRepository.ObtenerProductoPorCodigo(idProducto);


            if (producto.Stock < cantidad)
            {
                MessageBox.Show("No hay suficiente stock para completar la compra.");
                return;
            }
            if (producto != null)
            {
                producto.Stock -= cantidad;
                ProductoRepository.ActualizarProducto(producto);
            }

            DetallePedidoRepository.GuardarDetalles(nuevoPedido);


            MessageBox.Show("Pedido guardado exitosamente");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            comboBox1.SelectedIndex = -1;


        }

        private void Form6_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "XS", "S", "M", "L", "XL", "XXL" });
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
            this.Close();
        }
    }
}
