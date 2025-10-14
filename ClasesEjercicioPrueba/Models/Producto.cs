using ClasesModelo.Models;
using System.ComponentModel.DataAnnotations;

namespace ClasesEjercicioPrueba.Models
{
    public class Producto
    {

        [Key] public int IdProducto { get; set; }
        
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Talla { get; set; }

        public decimal Precio { get; set; }

        public int CategoriaId { get; set; }

        public int Stock { get; set; }

        public Categoria Categoria { get; set; }

        public Producto()
        {
        }

        public Producto(string nombre, string descripcion, string talla, decimal precio, int categoriaId, int stock)
        {
        
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Talla = talla;
            this.Precio = precio;
            this.CategoriaId = categoriaId;
            this.Stock = stock;
        }

    }
}
