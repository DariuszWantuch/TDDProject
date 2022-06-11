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
            Assert.Equal(50, dollar.GetAmount());
            dollar.Multiplication(10);
            Assert.Equal(500, dollar.GetAmount());
        }

        [Fact]
        public void DollarEqualityTest()
        {
            Assert.True(new Dollar(50).Equals(new Dollar(50)));
        }

        [Fact]
        public void FrancTestMultiplication()
        {
            Franc franc = new Franc(10);
            franc.Multiplication(5);
            Assert.Equal(50, franc.GetAmount());
            franc.Multiplication(10);
            Assert.Equal(500, franc.GetAmount());
        }

        [Fact]
        public void FrancEqualityTest()
        {
            Assert.True(new Franc(50).Equals(new Franc(50)));
        }
    }
}