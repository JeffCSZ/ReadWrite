using employeeApi.Models;
using employeeApi.Utils;

namespace employeeApi.Data
{
	public class RegionRepo(MyDBContext _dbContext) : IRegionRepo
	{
		public List<Region> GetRegion()
		{
			var reader = new ReadData();
		    var regionString = reader.DeptLocRegionState("TestData.csv");
			foreach (var r in regionString)
			{
				_dbContext.Region.Add(new Region() {RegionName = r } );
			}
			_dbContext.SaveChanges(); 
			return _dbContext.Region.ToList();
		}
	}
}
