using ClasesEjercicioPrueba.Repository;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 nuevaVentana = new Form1();
            nuevaVentana.Show();      // Muestra la nueva ventana
            this.Hide();              // Oculta el formulario actual (opcional)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Buscar cliente por DNI
            int dniBuscado = int.Parse(textBox1.Text);
            Cliente cliente = ClienteRepository.ObtenerClientePorDni(dniBuscado);
            if (cliente != null)
            {
                // Mostrar los datos del cliente en los TextBox correspondientes
                int.TryParse(textBox2.Text, out int idCliente);
                textBox2.Text = cliente.IdCliente.ToString();
                textBox3.Text = cliente.Nombre;
                textBox4.Text = cliente.Apellido;
                textBox5.Text = cliente.Email;
                textBox6.Text = cliente.Telefono;

            }
            else
            {
                MessageBox.Show("Cliente no encontrado");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Guardar cambios en el cliente
            if (string.IsNullOrEmpty(textBox1.Text) ||
               string.IsNullOrEmpty(textBox2.Text) ||
               string.IsNullOrEmpty(textBox4.Text) ||
               string.IsNullOrEmpty(textBox5.Text) ||
               string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Validar teléfono
            if (!textBox6.Text.All(char.IsLetter))
            {
                MessageBox.Show("El teléfono solo debe contener números.");
                return;
            }
            // Validar nombre y apellido 
            if (!textBox3.Text.All(char.IsLetter))
            {
                MessageBox.Show("El nombre solo debe contener letras.");
                return;
            }
            if (!textBox4.Text.All(char.IsLetter))
            {
                MessageBox.Show("El apellido solo debe contener letras.");
                return;
            }




            {
                var clienteActualizado = new Cliente(
                textBox3.Text,  // nombre
                textBox4.Text,  // Apellido
                textBox5.Text,  // email
                int.Parse(textBox1.Text),  // Dni
                textBox6.Text   // telefono
            );
                clienteActualizado.IdCliente = int.Parse(textBox2.Text);
                ClienteRepository.ActualizarCliente(clienteActualizado);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();


                MessageBox.Show("Cliente actualizado correctamente.");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(textBox1.Text);
            // Muestra un mensaje de confirmación
            var resultado = MessageBox.Show("Seguro que quiere eliminar el cliente.", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                ClienteRepository.EliminarCliente(dni);
                MessageBox.Show("Cliente eliminado correctamente.");
            }

            // Limpia los campos del formulario
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
    }
}
