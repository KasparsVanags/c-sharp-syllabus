using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace Minesweeper.Tests
{
    [TestClass]
    public class BoardTests
    {
        [Fact]
        public void TestMethod1()
        {
            var a = 3;
            var b = 5;
            var c = a + b;
            c.Should().Be(6);
        }
    }
}
