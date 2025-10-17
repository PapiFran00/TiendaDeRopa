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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            var productos = ProductoRepository.ObtenerProductos();
            dataGridView1.DataSource = productos;
            var vista = productos.Select(p => new
            {
                p.IdProducto,
                p.Nombre,
                p.Descripcion,
                Categoria = p.Categoria.Nombre,
                p.Stock,
                p.Precio
            }).ToList();

            dataGridView1.DataSource = vista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Close();
        }
    }
}
