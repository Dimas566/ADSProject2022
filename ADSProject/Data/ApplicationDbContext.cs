using ADSProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ADSProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<EstudianteViewModel> Estudiantes { get; set; }
        public DbSet<MateriaViewModel> Materias { get; set; }
        public DbSet<CarreraViewModel> Carreras { get; set; }  
        public DbSet<ProfesorViewModel> Profesores { get; set; }
        public DbSet<GrupoViewModel> Grupos { get; set; }
    }
}
