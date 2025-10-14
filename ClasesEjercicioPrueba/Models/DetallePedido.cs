using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ClasesModelo.Models
{
    public class DetallePedido
    {

        [Key] public int IdDetallePedido { get; set; }

        public int IdPedido { get; set; }

        public int IdProducto { get; set; }
        public int Cantidad { get; set; }

        public string Talla { get; set; }

        public decimal PrecioUnitario { get; set; }

        public decimal Subtotal { get; set; }

        public DetallePedido()
        {
        }

        public DetallePedido(int idPedido, int idProducto, int cantidad,string talla, decimal precioUnitario)
        {
            this.IdPedido = idPedido;
            this.IdProducto = idProducto;
            this.Cantidad = cantidad;
            this.Talla = talla;
            this.PrecioUnitario = precioUnitario;
            this.Subtotal = cantidad * precioUnitario;
           
        }


    }
}
