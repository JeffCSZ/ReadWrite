using employeeApi.Models;
using employeeApi.Utils;

namespace employeeApi.Data
{
	public class StateRepo(MyDBContext _dbContext) : IStateRepo
	{
		public List<State> GetStates()
		{
			var reader = new ReadData();
		    var stateString = reader.DeptLocRegionState("TestData.csv");
			foreach (var s in stateString)
			{
				_dbContext.State.Add(new State() {StateName = s } );
			}
			_dbContext.SaveChanges(); 
			return _dbContext.State.ToList();
		}
	}
}
