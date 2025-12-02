using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace GestEmpAspNet.Controllers
{
    public class DepartementController :Controller
    {
        private readonly IDepartementService _departementService;
        private readonly ILogger<DepartementController> _logger;

        public DepartementController(IDepartementService departementService,ILogger<DepartementController> logger)
        {
            _departementService = departementService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                var departements = _departementService.GetDepartements();
                return View(departements);
            }
            catch (Exception)
            {
                // Log the exception (not implemented here for brevity)
                _logger.LogError("An error occurred while loading the departement index.");
                return View(new List<Departement>());
            };
        }
        [HttpPost]
        public IActionResult Create()
        {
            return View();
        }
    }
}