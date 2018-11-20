using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using CoreAPIDemo.Models;

namespace CoreAPIDemoTests
{
    public class MockEmployeeRepository: IPatientRepository
    {
        public bool AddEmployee(PatientModel employee)
        {
            return true;
        }

        public IEnumerable<PatientModel> GetEmployees()
        {
            var employees = new List<PatientModel>
            {
                new PatientModel {Id = 1, Firstname = "Sam", Lastname = "Smith", Email = "S.Smith@test.com"},
                new PatientModel {Id = 2, Firstname = "Jane", Lastname = "Smith", Email = "j.Smith@test.com"}
            };

            return employees;
        }
    }
}
