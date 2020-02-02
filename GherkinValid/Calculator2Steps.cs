using GherkingWithNunit;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace GherkinValid
{
    [Binding]
    public class Calculator2Steps
    {
        Calculator calculator;

        public Calculator2Steps()
        {
            calculator = new Calculator();
        }

        [Before]
        public void SetUp()
        {
            Console.WriteLine("before");
        }
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int num)
        {
            calculator.nums.Add(num);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            calculator.Add();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int num)
        {
            Assert.AreEqual(num, calculator.Sum);
        }

        [After]
        public void TearDown()
        {
            Console.WriteLine("after");

        }
    }
}
