using Microsoft.EntityFrameworkCore;

namespace ProjetoCurso.Data
{
    public class ProjetoCursoContext : DbContext
    {
        public ProjetoCursoContext (DbContextOptions<ProjetoCursoContext> options)
            : base(options)
        {
        }
        public DbSet<Models.Department> Department { get; set; }
        public DbSet<Models.Seller> Seller { get; set; }
        public DbSet<Models.SalesRecord> SalesRecords { get; set; }
    }
}
