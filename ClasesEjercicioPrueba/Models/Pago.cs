using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ClasesModelo.Models
{
    public class Pago
    {
       [Key] public int IdPago { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }
        public int IdFactura { get; set; }

        public int IdPedido { get; set; }

        public Pago(DateTime fechaPago, decimal monto, int idFactura, int idPedido)
        {
            this.FechaPago = fechaPago;
            this.Monto = monto;
            this.IdFactura = idFactura;
            this.IdPedido = idPedido;
        }
    }
}
