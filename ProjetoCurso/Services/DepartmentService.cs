using ProjetoCurso.Data;
using ProjetoCurso.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoCurso.Services
{
    public class DepartmentService
    {
        private readonly ProjetoCursoContext _context;

        public DepartmentService(ProjetoCursoContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
