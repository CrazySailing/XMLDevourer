using System;
using Xunit;
using XMLDevourer.Utils;

namespace XMLDevourer.Tests
{
    public class UtilsTests
    {
        /*
        Incomplete tests on IsPrime
        */
        [Fact]
        public void IsPrimeTest()
        {
            Assert.Throws<NotImplementedException>(() => Utils.Utils.IsPrime(-3));
            Assert.Throws<NotImplementedException>(() => Utils.Utils.IsPrime(0));

            Assert.False(Utils.Utils.IsPrime(1), "1 should not be prime");
            Assert.False(Utils.Utils.IsPrime(2), "2 should not be prime");
            Assert.False(Utils.Utils.IsPrime(42), "42 should not be prime");

            Assert.True(Utils.Utils.IsPrime(3), "3 should be prime");
            Assert.True(Utils.Utils.IsPrime(7), "7 should be prime");
        }
    }
}
