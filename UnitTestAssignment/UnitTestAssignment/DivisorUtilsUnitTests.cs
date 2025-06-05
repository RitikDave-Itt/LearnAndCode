using Xunit;
using System;
using UnitTestAssignment.CustomExceptions;

namespace UnitTest
{
    public class DivisorUtilsUnitTests
    {
        [Fact]
        public void SampleCase_10()
        {
            int result = DivisorUtils.CountPairsWithEqualDivisors(10);
            Assert.Equal(1, result);
        }

        [Fact]
        public void TestZero()
        {
            int result = DivisorUtils.CountPairsWithEqualDivisors(0);
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestNegative_ShouldThrowException()
        {
            Assert.Throws<InvalidInputException>(() =>
                DivisorUtils.CountPairsWithEqualDivisors(-5)
            );
        }

        [Fact]
        public void TestOne()
        {
            int result = DivisorUtils.CountPairsWithEqualDivisors(1);
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestLargerNumber()
        {
            int result = DivisorUtils.CountPairsWithEqualDivisors(100);
            Assert.True(result > 0);
        }
    }
}
