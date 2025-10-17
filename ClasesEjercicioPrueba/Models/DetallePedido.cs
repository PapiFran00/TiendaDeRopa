using ClasesEjercicioPrueba.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClasesModelo.Models
{
    public class DetallePedido
    {

        [Key] public int IdDetallePedido { get; set; }

        public DateTime FechaPedido { get; set; }
        public int IdCliente { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public string Talla { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Total { get; set; }

        public DetallePedido()
        {
        }

        public DetallePedido(DateTime fechaPedido, int idCliente, int idProducto, int cantidad,string talla, decimal precioUnitario, decimal total)
        {
            this.FechaPedido = fechaPedido;
            this.IdCliente = idCliente;
            this.IdProducto = idProducto;
            this.Cantidad = cantidad;
            this.Talla = talla;
            this.PrecioUnitario = precioUnitario;
          
            this.Total = total;
        }

    }
}
