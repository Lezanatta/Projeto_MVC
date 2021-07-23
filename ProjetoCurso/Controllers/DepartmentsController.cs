using Microsoft.AspNetCore.Mvc;
using ProjetoCurso.Models;
using System.Collections.Generic;

namespace ProjetoCurso.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list= new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronics" });
            list.Add(new Department { Id = 2, Name = "TV" });
            list.Add(new Department { Id = 3, Name = "Phone" });

            return View(list);
        }
    }
}
