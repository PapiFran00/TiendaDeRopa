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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime desde = dateTimePicker1.Value.Date;
            DateTime hasta = dateTimePicker2.Value.Date.AddDays(1).AddTicks(-1); // incluir todo el día

            var pedidos = DetallePedidoRepository.ObtenerPedidosPorPeriodo(desde, hasta);

            if (pedidos.Count == 0)
            {
                MessageBox.Show("No se encontraron ventas en ese período.");
                dataGridView1.DataSource = null;
                return;
            }

            // Mostrar datos amigables
            var vista = pedidos.Select(static p => new
            {
                ID = p.IdDetallePedido,
                Fecha = p.FechaPedido.ToShortDateString(),
                Cliente = p.IdCliente,
                Total = p.Total
            }).ToList();

            dataGridView1.DataSource = vista;
            if (dataGridView1.Columns["ID"] != null)
            {
                dataGridView1.Columns["ID"].HeaderText = "ID Pedido";
            }

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }

}
