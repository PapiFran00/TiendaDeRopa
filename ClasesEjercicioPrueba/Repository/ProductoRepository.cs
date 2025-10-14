using ClasesEjercicioPrueba.Data1;
using ClasesEjercicioPrueba.Models;
using ClasesModelo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static Producto ObtenerProductoPorCodigo(int codigoBuscado)
        {
            using var context = new ApplicationDbContext();
            return context.Productos.FirstOrDefault(p => p.IdProducto == codigoBuscado);
        }

        public static void ActualizarProducto(Producto codigoAactualizar)
        {
            using var context = new ApplicationDbContext();
            var productoExistente = context.Productos.Find(codigoAactualizar.IdProducto);
            if (productoExistente != null)
            {
                context.Entry(productoExistente).CurrentValues.SetValues(codigoAactualizar);
                context.SaveChanges();
            }
        }
        public static void EliminarProducto(int codigoAEliminar)
        {
            using var context = new ApplicationDbContext();
            var producto = context.Productos.Find(codigoAEliminar);
            if (producto != null)
            {
                context.Productos.Remove(producto);
                context.SaveChanges();
            }
        }
    }
}
