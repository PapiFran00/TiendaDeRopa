using ClasesEjercicioPrueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ClasesModelo.Models
{
    public class Pedido
    {
        [Key] public int IdPedido { get; set; }
        public DateTime FechaPedido { get; set; }

        public decimal Total { get; set; }



        public int IdCliente { get; set; }

        public int Cantidad { get; set; }

        public List<Producto> Productos { get; set; }

        public Pedido(DateTime fechaPedido, int idCliente,int cantidad, decimal total)
        {
            this.FechaPedido = fechaPedido;
            this.IdCliente = idCliente;          
            this.Cantidad = cantidad;
            this.Total = total;
            this.Productos = new List<Producto>();
        }
    }
}
