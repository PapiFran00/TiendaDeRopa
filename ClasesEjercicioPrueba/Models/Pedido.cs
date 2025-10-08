using ClasesEjercicioPrueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesModelo.Models
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public DateTime FechaPedido { get; set; }

        public decimal Total { get; set; }

        public int IdCliente { get; set; }

        public List<Producto> Productos { get; set; }

        public Pedido(DateTime fechaPedido, decimal total, int idCliente)
        {
            this.FechaPedido = fechaPedido;
            this.Total = total;
            this.IdCliente = idCliente;
            this.Productos = new List<Producto>();
        }
    }
}
