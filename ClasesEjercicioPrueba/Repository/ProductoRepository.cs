using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesEjercicioPrueba.Data1;
using ClasesEjercicioPrueba.Models;

namespace ClasesEjercicioPrueba.Repository
{
    public static class ProductoRepository
    {
        public static void GuardarProducto(Producto producto)
        {
            using var context = new ApplicationDbContext();
            context.Productos.Add(producto);

            context.SaveChanges();
        }

        public static List<Producto> ObtenerProductos()
        {
            using var context = new ApplicationDbContext();
            return context.Productos.ToList();
        }

        public static void ActualizarProducto(Producto producto)
        {
            using var context = new ApplicationDbContext();
            context.Productos.Update(producto);
            context.SaveChanges();
        }
        public static void EliminarProducto(Producto producto)
        {
            using var context = new ApplicationDbContext();
            context.Productos.Remove(producto);
            context.SaveChanges();
        }
    }
}
