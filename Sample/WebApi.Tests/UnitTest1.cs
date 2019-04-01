using Xunit;

using WebApi;
namespace WebApi.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var foo = new DefaultController();
            Assert.True(foo != null, "");
        }
    }
}
