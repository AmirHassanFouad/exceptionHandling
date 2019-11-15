using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleCalculator.Tests.MSTest
{
    [TestClass]
    public class CalculatorShould
    {
        [TestMethod]
        public void ThrowWhenUnspportedOperation()
        {
          //  var calculator = new Calculator();

            // Assert.ThrowsException<CalculationOperationNotSupportedException>(() => calculator.Calculate(1, 1, "+"));

            // Assert.ThrowsException<CalculationException>(() => calculator.Calculate(1, 1, "+"));

            //var ex = Assert.ThrowsException<CalculationOperationNotSupportedException>(() => calculator.Calculate(1, 1, "+"));
            //Assert.AreEqual("+", ex.Operation);
        }
    }
}
