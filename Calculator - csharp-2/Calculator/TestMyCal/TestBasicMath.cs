using System;
using System.Collections.Generic;
using System.Text;
using Calculator;
using Xunit;

namespace TestMyCal
{
    public class TestBasicMath
    {
        [Fact]
        public void AddNumbers()
        {
            //arrange
            int expected = 5;

            //action
            BasicMath calc1 = new BasicMath();
            int actual = calc1.Add(2, 3);

            //assertion
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubtractNumbers()
        {
            //arrange
            int expected = -10;

            //action
            BasicMath calc2 = new BasicMath();
            int actual = calc2.Subtract(-20, -10);

            //assertion
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MultiplyNumbers()
        {
            //arrange
            int expected = 100;

            //action
            BasicMath calc3 = new BasicMath();
            int actual = calc3.Multiply(50, 2);

            //assertion
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 0, 0)]
        [InlineData(0, 4, 0)]
        [InlineData(10, 5, 2)]
        public void DivideNumbers(int a, int b, int expected)
        {
            //action
            BasicMath calc3 = new BasicMath();
            int actual = calc3.Division(a, b);

            //assertion
            Assert.Equal(expected, actual);
            //Assert.eq
        }
    }
}
