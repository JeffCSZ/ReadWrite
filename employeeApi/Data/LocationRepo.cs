using employeeApi.Models;
using employeeApi.Utils;

namespace employeeApi.Data
{
	public class LocationRepo(MyDBContext _dbContext) : ILocationRepo
	{
		public List<Location> GetLocations()
		{
			var reader = new ReadData();
		    var locationString = reader.DeptLocRegionState("TestData.csv");
			foreach (var l in locationString)
			{
				_dbContext.Location.Add(new Location() {LocationName = l } );
			}
			_dbContext.SaveChanges(); 
			return _dbContext.Location.ToList();
		}
    }
}
