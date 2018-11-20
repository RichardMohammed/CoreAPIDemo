using System.Collections.Generic;

namespace CoreAPIDemo.Models
{
    public interface IPatientRepository
    {
        bool AddEmployee(PatientModel employee);
        IEnumerable<PatientModel> GetEmployees();
        dynamic GetEmployeeById(int id);
    }
}