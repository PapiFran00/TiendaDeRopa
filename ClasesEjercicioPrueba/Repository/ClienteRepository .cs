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
    public static class ClienteRepository
    {
        public static void GuardarCliente(Cliente cliente)
        {
            using var context = new ApplicationDbContext();
            context.Clientes.Add(cliente);

            context.SaveChanges();
        }

        public static List<Cliente> ObtenerClientes()
        {

            using var context = new ApplicationDbContext();
            return context.Clientes.ToList();

        }

        public static Cliente ObtenerClientePorDni(int dniBuscado)
        {
            using var context = new ApplicationDbContext();
            return context.Clientes.FirstOrDefault(c => c.Dni == dniBuscado);
        }

        public static Cliente GetClientByID(int ID)
        {
            using var context = new ApplicationDbContext();
            return context.Clientes.FirstOrDefault(c => c.IdCliente == ID);
        }

        public static void ActualizarCliente(Cliente cliente)
        {
            using var context = new ApplicationDbContext();
            context.Clientes.Update(cliente);
            context.SaveChanges();
        }
        public static void EliminarCliente(int dni)
        {
            using var context = new ApplicationDbContext();
            var cliente = context.Clientes.FirstOrDefault(c => c.Dni == dni);
            if (cliente != null)
            {
                context.Clientes.Remove(cliente);
                context.SaveChanges();
            }
        }
    }
}
