using ClasesEjercicioPrueba.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaDeRopa
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

            var clientes = ClienteRepository.ObtenerClientes();
            dataGridView1.DataSource = clientes;
            var vista = clientes.Select(c => new
            {
                c.IdCliente,
                c.Nombre,
                c.Apellido,
                c.Dni,
                c.Email,
                c.Telefono
            }).ToList();

            dataGridView1.DataSource = vista;
        }
    }
}
