using System;
using Xunit;
using Mathematics.Lib;


namespace Mathematics.Lib.Tests
{
    public class NaturalNUmberCalculatorTests
    {
        [Fact]
        public void AddMethon_Numbers_Success()
        {
            var calculator = new NaturalNUmberCalculator();
            int result = calculator.Add(1,2);
            Assert.Equal(3,result);
        }

        [Fact]
        public void SubstractMethod_Numbers_Success()
        {
            var calculator = new NaturalNUmberCalculator();
            int result = calculator.Substract(2, 2);
            Assert.Equal(0, result);
        }

        [Fact]
        public void DivideMethod_Numbers_Success()
        {
            var calculator = new NaturalNUmberCalculator();
            int result = calculator.Divide(2, 2);
            Assert.Equal(1, result);
        }

        [Fact]
        public void MultiplyMethod_Numbers_Success()
        {
            var calculator = new NaturalNUmberCalculator();
            int result = calculator.Multiply(4, 2);
            Assert.Equal(8, result);
        }
    }
}
