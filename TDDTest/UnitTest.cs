using TDDProject.Model;
using Xunit;

namespace TDDTest
{
    public class UnitTest
    {
        [Fact]
        public void DolarTestMultiplication()
        {
            Dollar dollar = new Dollar(10);
            dollar.Multiplication(5);
            Assert.Equal(50, dollar.amount);
            dollar.Multiplication(10);
            Assert.Equal(500, dollar.amount);
        }
    }
}