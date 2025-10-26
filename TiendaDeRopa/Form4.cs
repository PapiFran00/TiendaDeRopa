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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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
            //Agregar cliente nuevo a la base de datos

            if (string.IsNullOrEmpty(textBox1.Text) ||
               string.IsNullOrEmpty(textBox2.Text) ||
               string.IsNullOrEmpty(textBox4.Text) ||        
               string.IsNullOrEmpty(textBox5.Text) ||
               string.IsNullOrEmpty(textBox3.Text))

            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            //Validacion dni
            if (!int.TryParse(textBox4.Text, out int dni))
            {
                MessageBox.Show("El DNI debe ser un número válido.");
                return;
            }
   
            if (textBox4.Text.Length < 7 || textBox4.Text.Length > 8)
            {
                MessageBox.Show("El DNI debe tener entre 7 y 8 dígitos.");
                return;
            }

            if (ClasesEjercicioPrueba.Repository.ClienteRepository.ObtenerClientePorDni(dni) != null)
            {
                MessageBox.Show("Ya existe un cliente con ese DNI.");
                return;
            }

            // Validar nombre y apellido (solo letras)

            if (!textBox1.Text.All(char.IsLetter))
            {
                MessageBox.Show("El nombre solo debe contener letras.");
                return;
            }

            if (!textBox2.Text.All(char.IsLetter))
            {
                MessageBox.Show("El apellido solo debe contener letras.");
                return;
            }

            if (textBox5.Text.All(char.IsLetter))
            {
                MessageBox.Show("El teléfono solo debe contener numeros.");
                return;
            }


            // Crear el cliente con los valores de los TextBox
            var nuevoCliente = new Cliente(
                textBox1.Text,  // nombre
                textBox2.Text,  // Apellido
                textBox3.Text,  // email
                int.Parse(textBox4.Text),  // Dni
                textBox5.Text   // telefono
            );

            // Guardarlo en la base
            ClasesEjercicioPrueba.Repository.ClienteRepository.GuardarCliente(nuevoCliente);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();


            MessageBox.Show("Cliente agregado correctamente.");
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}