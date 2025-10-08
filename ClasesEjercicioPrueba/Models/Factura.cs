using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesModelo.Models
{
    public class Factura
    {

        public int IdFactura { get; set; }
        public DateTime FechaFactura { get; set; }

        public string Tipo { get; set; }
        public decimal Total { get; set; }
        public int IdPedido { get; set; } 
        public List<DetallePedido> Detalles { get; set; }

        public Factura(DateTime fechaFactura, decimal total, int idPedido)
        {
            this.FechaFactura = fechaFactura;
            this.Total = total;
            this.IdPedido = idPedido;
            this.Detalles = new List<DetallePedido>();
        }
    }
}
