using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using CoreAPIDemo.Models;

namespace CoreAPIDemoTests
{
    public class MockEmployeeRepository: IEmployeeRepository
    {
        public bool AddEmployee(EmployeeModel employee)
        {
            return true;
        }

        public IEnumerable<EmployeeModel> GetEmployees()
        {
            var employees = new List<EmployeeModel>
            {
                new EmployeeModel {Id = 1, Firstname = "Sam", Lastname = "Smith", Email = "S.Smith@test.com"},
                new EmployeeModel {Id = 2, Firstname = "Jane", Lastname = "Smith", Email = "j.Smith@test.com"}
            };

            return employees;
        }
    }
}
