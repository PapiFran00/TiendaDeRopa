using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesModelo.Models
{
    public class Cliente
    {

        [Key] public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }

        public int Dni { get; set; }
        public string Telefono { get; set; }

        public Cliente(string nombre, string apellido, string email, int dni, string telefono)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Dni = dni;
            this.Telefono = telefono;
        }
    }
}
