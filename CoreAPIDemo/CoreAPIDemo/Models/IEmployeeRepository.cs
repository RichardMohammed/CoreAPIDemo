using System.Collections.Generic;

namespace CoreAPIDemo.Models
{
    public interface IEmployeeRepository
    {
        bool AddEmployee(EmployeeModel employee);
        IEnumerable<EmployeeModel> GetEmployees();
    }
}