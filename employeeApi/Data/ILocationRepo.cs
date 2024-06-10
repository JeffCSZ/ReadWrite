using employeeApi.Models;

namespace employeeApi.Data
{
    public interface ILocationRepo
    {
        List<Location> GetLocations();
    }
}
