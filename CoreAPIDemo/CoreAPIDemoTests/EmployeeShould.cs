using System.Linq;
using CoreAPIDemo.Controllers;
using CoreAPIDemo.Models;
using Xunit;

namespace CoreAPIDemoTests
{
    public class EmployeeShould
    {
        private readonly EmployeeController _controller;

        public EmployeeShould()
        {
            var repo = new MockEmployeeRepository();
            _controller = new EmployeeController(repo);   
        }

        [Fact]
        public void Fetch_Employees_List()
        {
            var employees = _controller.Get();
            Assert.True(employees.Any());
        }

        [Fact]
        public void Be_Able_To_Register()
        {
            var emp = new EmployeeModel {Id = 1, Firstname = "Sam", Lastname = "Brown", Email = "s.brown@test.com"};
            var result = _controller.Post(emp);
            Assert.True(result);
        }
    }
}