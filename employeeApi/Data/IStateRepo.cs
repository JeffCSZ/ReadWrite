using employeeApi.Models;

namespace employeeApi.Data
{
    public interface IStateRepo
    {
        List<State> GetStates();
    }
}
