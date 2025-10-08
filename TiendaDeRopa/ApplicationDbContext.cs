
namespace TiendaDeRopa
{
    internal class ApplicationDbContext
    {
        public ApplicationDbContext()
        {
        }

        public object Productos { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}