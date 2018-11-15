using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPIDemo.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext _ctx;
        public EmployeeRepository(EmployeeContext context)
        {
            _ctx = context;
        }

        public IEnumerable<EmployeeModel> GetEmployees()
        {
            return _ctx.Employee;
        }

        public bool AddEmployee(EmployeeModel employee)
        {
            try
            {
                _ctx.Employee.Add(employee);
                _ctx.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
