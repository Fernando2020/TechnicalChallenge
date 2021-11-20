using TechnicalChallenge.Shared.Functions;
using Xunit;

namespace TechnicalChallenge.Tests.Functions
{
    public class MathFunctionsTest
    {
        [Theory]
        [InlineData(8, 1)]
        [InlineData(8, 2)]
        [InlineData(8, 4)]
        [InlineData(8, 8)]
        public void IsDivider_True_Theory(long divider, long dividend)
        {
            var exec = MathFunctions.IsDivider(divider, dividend);

            Assert.True(exec);
        }

        [Theory]
        [InlineData(8, 3)]
        [InlineData(8, 5)]
        [InlineData(8, 9)]
        public void IsDivider_False_Theory(long divider, long dividend)
        {
            var exec = MathFunctions.IsDivider(divider, dividend);

            Assert.False(exec);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(5)]
        [InlineData(7)]
        public void IsPrimeNumbers_True_Theory(long number)
        {
            var exec = MathFunctions.IsPrimeNumber(number);

            Assert.True(exec);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(30)]
        public void IsPrimeNumbers_False_Theory(long number)
        {
            var exec = MathFunctions.IsPrimeNumber(number);

            Assert.False(exec);
        }

        [Fact]
        public void IsDivider_True_Fact()
        {
            var number = 45;

            var exec = MathFunctions.IsDivider(number, 5);

            Assert.True(exec);
        }

        [Fact]
        public void IsDivider_False_Fact()
        {
            var number = 45;

            var exec = MathFunctions.IsDivider(number, 2);

            Assert.False(exec);
        }

        [Fact]
        public void IsPrimeNumbers_True_Fact()
        {
            var number = 7;

            var exec = MathFunctions.IsPrimeNumber(number);

            Assert.True(exec);
        }

        [Fact]
        public void IsPrimeNumbers_False_Fact()
        {
            var number = 8;

            var exec = MathFunctions.IsPrimeNumber(number);

            Assert.False(exec);
        }
    }
}
