using System.Linq;
using CoreAPIDemo.Controllers;
using Xunit;
using Xunit.Abstractions;

namespace CoreAPIDemoTests
{
    public class ValuesControllerShould
    {
        private ValuesController _controller;
        private ITestOutputHelper _output;

        public ValuesControllerShould(ITestOutputHelper output)
        {
            _controller = new ValuesController();
            _output = output;
        }

        [Fact]
        public void Return_2_Values()
        {
           var result = _controller.Get();
            var value = result.Value.ToList();
            _output.WriteLine(value.Count.ToString());
            _output.WriteLine(value[0]);
            _output.WriteLine(result.Value.ToList()[1]);

            Assert.True(value.Count == 2);
            Assert.True(value[1] == "value2");
        }
       
    }
}
