using ClasesModelo.Models;

namespace ClasesEjercicioPrueba.Models
{
    public class Producto
    {

        public int IdProducto;
        
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Talla { get; set; }

        public decimal Precio { get; set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

       
        public Producto(string nombre, string descripcion, string talla, decimal precio, int categoriaId)
        {
        
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Talla = talla;
            this.Precio = precio;
            this.CategoriaId = categoriaId;
        }






    }
}
