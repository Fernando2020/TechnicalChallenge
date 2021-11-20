using System.Collections.Generic;
using TechnicalChallenge.Core.Entities;
using TechnicalChallenge.Manager.Implementations;
using Xunit;

namespace TechnicalChallenge.Tests.Implementations
{
    public class DividerManagerTest
    {
        private readonly DividerManager _dividerManager;
        public DividerManagerTest()
        {
            _dividerManager = new DividerManager();
        }

        [Fact]
        public void GetDividerAndPrimeNumbers_Dividers_IsSuccess_True()
        {
            var divider = new Divider { Number = 8 };
            var listDividers = new List<long> { 1, 2, 4, 8 };

            var response = _dividerManager.GetDividersAndPrimeNumbers(divider);

            Assert.True(response.IsSuccess);
            Assert.Null(response.Error);
            Assert.Equal(response.Dividers, listDividers);
        }

        [Fact]
        public void GetDividerAndPrimeNumbers_PrimeNumbers_IsSuccess_True()
        {
            var divider = new Divider { Number = 8 };
            var listPrimeNumbers = new List<long> { 2 };

            var response = _dividerManager.GetDividersAndPrimeNumbers(divider);

            Assert.True(response.IsSuccess);
            Assert.Null(response.Error);
            Assert.Equal(response.PrimeNumbers, listPrimeNumbers);
        }

        [Fact]
        public void GetDividerAndPrimeNumbers_Dividers_IsSuccess_False()
        {
            var divider = new Divider { Number = 0 };
            var listDividers = new List<long>();

            var response = _dividerManager.GetDividersAndPrimeNumbers(divider);

            Assert.False(response.IsSuccess);
            Assert.NotNull(response.Error);
            Assert.Equal(response.Dividers, listDividers);
        }

        [Fact]
        public void GetDividerAndPrimeNumbers_PrimeNumbers_IsSuccess_False()
        {
            var divider = new Divider { Number = 0 };
            var listPrimeNumbers = new List<long>();

            var response = _dividerManager.GetDividersAndPrimeNumbers(divider);

            Assert.False(response.IsSuccess);
            Assert.NotNull(response.Error);
            Assert.Equal(response.PrimeNumbers, listPrimeNumbers);
        }
    }
}
