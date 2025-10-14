using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ClasesModelo.Models
{
     public class ProductoProveedor
    {
        [Key] public int IdProductoProveedor { get; set; }
        public int IdProducto { get; set; }
        public int IdProveedor { get; set; }

        public decimal PrecioProveedor { get; set; }

     
        public ProductoProveedor(int idProducto, int idProveedor, decimal precioProveedor)
        {
            this.IdProducto = idProducto;
            this.IdProveedor = idProveedor;
            this.PrecioProveedor = precioProveedor;
        }



    }
}
