using GherkingWithNunit;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTests
{
    public class CalculatorTests
    {
        Calculator calculator;

        public CalculatorTests()
        {
            calculator = new Calculator();
        }

        [OneTimeSetUp]
        public void SetUpFixture()
        {
            Console.WriteLine("beforeRun");

        }
        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("before");
        }

        [Test]
        public void GivenIHaveEnteredIntoTheCalculator()
        {
            calculator.nums.Add(50);
            calculator.nums.Add(70);
            calculator.Add();
            Assert.AreEqual(120, calculator.Sum);
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("after");

        }
        [OneTimeTearDown]
        public void TearDownFixture()
        {
            Console.WriteLine("beforeRun");

        }
    }
}
