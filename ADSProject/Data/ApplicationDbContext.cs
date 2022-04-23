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
    }
}
