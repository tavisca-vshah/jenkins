using System;
using Xunit;
using hello;
namespace helloTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("hello world", Program.test());
        }
    }
}
