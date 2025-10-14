using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesEjercicioPrueba.Data1;
using ClasesEjercicioPrueba.Models;
using ClasesModelo.Models;

namespace ClasesEjercicioPrueba.Repository
{
    public static class DetallePedidoRepository
    {
        public static void GuardarDetallePedido(DetallePedido nuevoDetalle)
        {
            using var context = new ApplicationDbContext();
            context.DetallePedidos.Add(nuevoDetalle);

            context.SaveChanges();
        }

        public static List<DetallePedido> ObtenerDetallePedidos()
        {
            using var context = new ApplicationDbContext();
            return context.DetallePedidos.ToList();
        }

        public static DetallePedido ObtenerDetallePedidoPorId(int idDetallePedido)
        {
            using var context = new ApplicationDbContext();
            return context.DetallePedidos.FirstOrDefault(d => d.IdDetallePedido == idDetallePedido);
        }

        
    }
}
