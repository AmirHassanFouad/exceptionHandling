using System;
using Xunit;

namespace ConsoleCalculator.Tests.XUnit
{    
    public class CalculatorShould
    {
        [Fact]
        public void ThrowWhenUnspportedOperation()
        {
            var calculator = new ConsoleCalculator.Calculator();

            Assert.Throws<CalculationOperationNotSupportedException>(() => calculator.Calculate(1, 1, "+"));
            Assert.ThrowsAny<CalculationException>(() => calculator.Calculate(1, 1, "+"));
            var ex = Assert.Throws<CalculationOperationNotSupportedException>(() => calculator.Calculate(1, 1, "+"));
            Assert.Equal("+", ex.Operation);
        }
    }
}
