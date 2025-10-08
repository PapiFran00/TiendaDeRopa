using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesModelo.Models
{
    public class DetallePedido
    {

        public int IdDetallePedido { get; set; }

        public int IdPedido { get; set; }

        public int IdProducto { get; set; }
        public int Cantidad { get; set; }

        public decimal PrecioUnitario { get; set; }

        public decimal Subtotal { get; set; }

        public DetallePedido(int idPedido, int idProducto, int cantidad, decimal precioUnitario)
        {
            this.IdPedido = idPedido;
            this.IdProducto = idProducto;
            this.Cantidad = cantidad;
            this.PrecioUnitario = precioUnitario;
            this.Subtotal = cantidad * precioUnitario;
        }


    }
}
