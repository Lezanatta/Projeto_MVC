using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoCurso.Models;

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
