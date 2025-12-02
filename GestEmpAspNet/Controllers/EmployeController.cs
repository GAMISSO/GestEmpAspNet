using Microsoft.AspNetCore.Mvc;

namespace GestEmpAspNet.Controllers
{
    public class EmployeController :Controller
    {
        public EmployeController()
        {
        }
        [HttpGet]
        public IActionResult Load()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create()
        {
            return View();
        }
    }
}