using Microsoft.AspNetCore.Mvc;
using Services;

namespace GestEmpAspNet.Controllers
{
    public class DepartementController :Controller
    {
        private readonly IDepartementService _departementService;

        public DepartementController(IDepartementService departementService)
        {
            _departementService = departementService;
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