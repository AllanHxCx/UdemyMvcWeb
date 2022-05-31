using Microsoft.AspNetCore.Mvc;

namespace SalesWebService.Controllers
{
    public class DepartmentsController : Controller
    {
        
        public IActionResult Index()
        {
            List < Department > list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronics" });
            list.Add(new Department { Id = 1, Name = "Fashion" });

            return View(list);
        }
    }
}
