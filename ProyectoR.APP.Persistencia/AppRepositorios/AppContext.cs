using Microsoft.EntityFrameworkCore;
using ProyectoR.App.Dominio;
 
namespace ProyectoR.App.Persistencia
{
    public class AppContext: DbContext{
        public DbSet<Estudiante> Estudiantes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ProyectoR");
            }
        }
    }
}
