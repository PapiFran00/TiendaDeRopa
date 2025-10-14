using ClasesEjercicioPrueba.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesModelo.Models
{
    public class Categoria
    {

         [Key] public int IdCategoria { get; set; }

        public string Nombre { get; set; }

       public List<Producto> Productos { get; set; }

        public Categoria(string nombre)
        {
            this.Nombre = nombre;
           
        }


    }
}
