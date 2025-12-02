using Data;
using Microsoft.Extensions.Logging;
using Models;


namespace Services
{
    public class DepartementService:IDepartementService
    {
        private readonly GestEmpDbContext _context;
        private readonly ILogger<DepartementService> _logger;
        public DepartementService(GestEmpDbContext context, ILogger<DepartementService> logger)
        {
            _context = context;
            _logger = logger;
        }
        public IEnumerable<Departement> GetDepartements()
        {
            try
            {
                return _context.Departements
                .Where(d => d.IsActive)
                .OrderByDescending(d => d.DateCreation)
                .ToList();
                // _logger.LogInformation("Fetching departements from database.");
            }
            catch (Exception)
            {
                _logger.LogError( "An error occurred while fetching departements.");
                throw;
            }
            
        }
    }
}