using Learning;
using System.Runtime.CompilerServices;

namespace MsTest
{
    [TestClass]
    public class PrimeClassTest
    {
        private PrimeClass primeService;
        public PrimeClassTest()
        {
            primeService = new PrimeClass();
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(-1)]
        [DataRow(4)]
        [DataRow(6)]
        [DataRow(8)]
        public void IsPrime_returnFalse(int value)
        {
            bool result = primeService.IsPrime(value);
            Assert.IsFalse(result, $"{value} should not be prime");
        }

        [DataTestMethod]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(5)]
        [DataRow(7)]
        //[Ignore]
        public void IsPrime_returnTrue(int value)
        {
            bool result = primeService.IsPrime(value);
            Assert.IsTrue(result, $"{value} should be prime");
        }
    }
}