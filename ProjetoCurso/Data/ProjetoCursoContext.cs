using Microsoft.EntityFrameworkCore;

namespace ProjetoCurso.Data
{
    public class ProjetoCursoContext : DbContext
    {
        public ProjetoCursoContext (DbContextOptions<ProjetoCursoContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoCurso.Models.Department> Department { get; set; }
    }
}
