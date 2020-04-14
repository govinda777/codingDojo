using System;
using Xunit;
using PrimeiroService;

namespace PrimeService.Tests
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeiroService.PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeiroService.PrimeService();
        }

        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = _primeService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }
    }
}
