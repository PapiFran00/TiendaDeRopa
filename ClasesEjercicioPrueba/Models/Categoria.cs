using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesModelo.Models
{
    public class Categoria
    {

        public int IdCategoria { get; set; }

        public string Nombre { get; set; }

        public string Subcategoria { get; set; }

        public Categoria(string nombre, string subcategoria)
        {
            this.Nombre = nombre;
            this.Subcategoria = subcategoria;
        }


    }
}
