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
    public static class PedidoRepository
    {
        public static void GuardarPedido(Pedido pedido)
        {
            using var context = new ApplicationDbContext();
            context.Pedidos.Add(pedido);

            context.SaveChanges();
        }

        public static List<Pedido> ObtenerPedidos()
        {
            using var context = new ApplicationDbContext();
            return context.Pedidos.ToList();
        }

        public static Pedido ObtenerPedidoPorId(int idPedido)
        {
            using var context = new ApplicationDbContext();
            return context.Pedidos.FirstOrDefault(p => p.IdPedido == idPedido);
        }

        
        
    }
}
