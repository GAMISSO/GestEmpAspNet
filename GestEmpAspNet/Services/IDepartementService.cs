using Models;

namespace Services
{
    public interface IDepartementService
    {
        IEnumerable<Departement> GetDepartements();
    }
}