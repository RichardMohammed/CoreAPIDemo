using CoreAPIDemo.Controllers;
using Xunit;

namespace CoreAPIDemoTests
{
    public class EmployeeShould
    {
        private readonly EmployeeController _controller;

        public EmployeeShould()
        {
         _controller = new EmployeeController();   
        }

        [Fact]
        public void Be_Able_To_Register()
        {
            var result = _controller.Post();
            Assert.True(result);
        }
    }
}