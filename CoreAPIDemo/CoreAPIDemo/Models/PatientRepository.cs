using System.Collections.Generic;
using System.Linq;

namespace CoreAPIDemo.Models
{
    public class PatientRepository : IPatientRepository
    {
        private readonly DatabaseContext _ctx;
        public PatientRepository(DatabaseContext context)
        {
            _ctx = context;
        }

        public IEnumerable<PatientModel> GetEmployees()
        {
            return _ctx.Patient;
        }

        public dynamic GetEmployeeById(int id)
        {
            return _ctx.Patient.Where(c => c.Id == id)
                .Select(o => new {o.Id, o.SurgeryId, o.Firstname, o.Lastname, o.Email});
        }

        public bool AddEmployee(PatientModel employee)
        {
            try
            {
                _ctx.Patient.Add(employee);
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
