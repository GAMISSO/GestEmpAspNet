using Microsoft.AspNetCore.Mvc;

namespace GestEmpAspNet.Controllers
{
    public class DashboardController :Controller
    {
        public DashboardController()
        {
        }
        [HttpGet]
        public IActionResult Index()
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