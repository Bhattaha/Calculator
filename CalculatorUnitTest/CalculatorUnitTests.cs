using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorUnitTests
    {
        ScientificCalculator calc = new ScientificCalculator();
        [TestMethod]
        public void AddTest()
        {
            Assert.AreEqual(7, calc.Add(3, 4));
        }
        [TestMethod]
        public void SubtractionTest()
        {
            Assert.AreEqual(8, calc.Subtraction(12, 4));
        }
        [TestMethod]
        public void MultiplyTest()
        {
            Assert.AreEqual(12, calc.Multiply(3, 4));
        }
        [TestMethod]
        public void Division()
        {
            Assert.AreEqual(7.0, calc.Division(28, 4));
        }
        [TestMethod]
        public void Percentile()
        {
            Assert.AreEqual(78, calc.Percentile(78, 100));
        }
    }
}

