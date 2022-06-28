
using System.Data.SqlTypes;
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
            dollar.Multiplication(2);
            Assert.False(999 == dollar.GetAmount());
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
            franc.Multiplication(2);
            Assert.False(999 == franc.GetAmount());
        }

        [Fact]
        public void FrancEqualityTest()
        {
            Assert.True(new Franc(50).Equals(new Franc(50)));
            Assert.False(new Franc(50).Equals(new Franc(51)));

        }

        [Fact]
        public void FrancDollarTest()
        {
            Assert.False(Money.Dollar(50).Equals(Money.Dollar(51)));
            Assert.True(Money.Dollar(50).Equals(Money.Dollar(50)));
        }

        [Fact]
        public void CurrencyTest()
        {
            Assert.Equal("USD", Money.Dollar(5).Currency());
            Assert.Equal("CHF", Money.Franc(5).Currency());
        }

        [Fact]
        public void DollarAdditionTest()
        {
            int dollarSum = Money.Dollar(10).Plus(20);
            Assert.Equal(30,dollarSum);
        }

        [Fact]
        public void FrancAdditionTest()
        {
            int francSum = Money.Franc(15).Plus(20);
            Assert.Equal(35, francSum);
        }

        [Fact]
        public void PrintCurrency()
        {
            Assert.True("10 USD" == Money.Dollar(10).ToString());
            Assert.True("50 CHF" == Money.Franc(50).ToString());
            Assert.False("10 USD" == Money.Dollar(20).ToString());
            Assert.False("50 CHF" == Money.Franc(100).ToString());
        }
    }
}