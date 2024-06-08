using System;
using conCsv.Model;

namespace conCsv.Data
{
    public class EmployeeRepo : IEmployee
    {
        //need to Depedency Inject DBContext
        private readonly AppDBContext _db;

        public EmployeeRepo(AppDBContext db)
        {
            _db = db;
        }

        public void AddEmployee(Employee employee)
        {
            _db.Add(employee);
            _db.SaveChanges();

        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _db.employees;
        }
    }
}

