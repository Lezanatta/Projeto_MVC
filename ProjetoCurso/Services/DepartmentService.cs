using ProjetoCurso.Data;
using ProjetoCurso.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoCurso.Services
{
    public class DepartmentService
    {
        private readonly ProjetoCursoContext _context;

        public DepartmentService(ProjetoCursoContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
