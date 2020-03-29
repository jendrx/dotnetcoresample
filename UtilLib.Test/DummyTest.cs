using Xunit;

namespace UtilLib.Test
{
    public class DummyTest
    {
        [Fact]
        public void TestSum()
        {
            Assert.Equal(2, MathUtil.Sum(1, 1));
        }

        [Fact]
        public void TestAnotherSum()
        {
            Assert.Equal(2, MathUtil.Sum(1, 1));
        }
    }
}
