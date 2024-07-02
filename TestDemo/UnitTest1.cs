
using CICD_Demo_With_AzureDevops;

namespace TestDemo
{
    public class UnitTest1
    {
        [Fact]
        public void MyName_PrintMyName_returns_Isaac()
        {
            var name = "Isaac";
            var myname = new MyName();
            var resultName = myname.GetMyName();
            Assert.Equal(name, resultName);
        }
    }
}