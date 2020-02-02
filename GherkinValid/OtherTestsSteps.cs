using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace GherkinValid
{
    [Binding]
    public class OtherTestsSteps
    {
        string firstString;
        string secondString;

        [Given(@"I have a string")]
        public void GivenIHaveAString()
        {
            firstString = "Yaay";
        }
        
        [When(@"I add string")]
        public void WhenIAddString()
        {
            secondString = "Cookies";
        }
        
        [Then(@"I got dual string!")]
        public void ThenIGotDualString()
        {
            Assert.AreEqual("YaayCookies", firstString + secondString);
        }
    }
}
