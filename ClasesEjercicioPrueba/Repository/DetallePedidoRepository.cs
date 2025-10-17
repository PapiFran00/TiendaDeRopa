using ClasesEjercicioPrueba.Data1;
using ClasesEjercicioPrueba.Models;
using ClasesModelo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEjercicioPrueba.Repository
{
    public static class DetallePedidoRepository
    {
        public static void GuardarDetalles(DetallePedido nuevoPedido)
        {
            using var context = new ApplicationDbContext();
            {
                context.DetallePedidos.Add(nuevoPedido);
                context.SaveChanges();
            }

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


        public static List<DetallePedido> ObtenerPedidosPorPeriodo(DateTime desde, DateTime hasta)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.DetallePedidos
                    .Where(p => p.FechaPedido >= desde && p.FechaPedido <= hasta)
               
                    .ToList();
            }
        }


    }
}
