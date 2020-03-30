using System;
using Xunit;

namespace UtilLib.FTest
{
    public class DummyFTest
    {
        [Fact]
        public void AnotherDummyTest()
        {
            Assert.Equal(1, 1);
        }
        
        [Fact]
        public void FailTest()
        {
            Assert.True(false);
        }
    }
}
