using ConsoleCalculator;
using NUnit.Framework;
using System;

namespace Console.Calculator.Test.NUnit
{
    public class CalculatorShould
    {
        [Test]
        public void ThrowWhenUnspportedOperation()
        {
            var calculator = new ConsoleCalculator.Calculator();

            Assert.That(() => calculator.Calculate(1, 1, "+"),
                Throws.TypeOf<CalculationOperationNotSupportedException>());

            Assert.That(() => calculator.Calculate(1, 1, "+"),
              Throws.TypeOf<CalculationOperationNotSupportedException>()
              .With.Property("Operation").EqualTo("+"));

            //fail
            //Assert.That(() => calculator.Calculate(1, 1, "+"),
            // Throws.TypeOf<CalculationException>());

            Assert.That(() => calculator.Calculate(1, 1, "+"),
             Throws.InstanceOf<CalculationException>());
        }
    }
}
