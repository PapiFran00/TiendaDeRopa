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
    public static class CategoriaRepository
    {

        //buscar todas las categorias
        public static List<Categoria> ObtenerCategorias()
        {
            using var context = new ApplicationDbContext();
            return context.Categorias.ToList();
        }

        
    }
}
