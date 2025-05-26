using Xunit;

namespace DivisorAssignment.Tests
{
    public class DivisorUtilsTests
    {
        [Fact]
        public void Test_SampleCase_10()
        {
            int result = DivisorUtils.CountMatchingDivisors(10);
            Assert.Equal(4, result); 
        }

        [Fact]
        public void Test_Zero()
        {
            int result = DivisorUtils.CountMatchingDivisors(0);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test_Negative()
        {
            int result = DivisorUtils.CountMatchingDivisors(-5);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test_One()
        {
            int result = DivisorUtils.CountMatchingDivisors(1);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Test_Larger()
        {
            int result = DivisorUtils.CountMatchingDivisors(100);
            Assert.True(result > 0);
        }
    }
}
