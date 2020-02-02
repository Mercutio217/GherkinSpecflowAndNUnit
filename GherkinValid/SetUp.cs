using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace GherkinValid
{
    [Binding]
    public static class SetUp
    {
        /*By default the hooks of the same type (e.g. two [BeforeScenario] hook) 
         * are executed in an unpredictable order. 
         * If you need to ensure a specific execution order, 
         * you can specify the Order property in the hook's attributes.*/
        [BeforeTestRun]
        public static void SetUpFixture()
        {
            Console.WriteLine("beforeRun");

        }


        [AfterTestRun]
        public static void TearDownFixture()
        {
            Console.WriteLine("beforeRun");

        }
        [BeforeTestRun]
        public static void SetUpFixture2()
        {
            Console.WriteLine("beforeRun2");

        }


        [AfterTestRun]
        public static void TearDownFixture2()
        {
            Console.WriteLine("beforeRun2");

        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            Console.WriteLine("Before scenario");
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            Console.WriteLine("After scenario");
        }

        [BeforeScenario("ConcatTag")]
        public static void BeforeConcat()
        {
            Console.WriteLine("Before scenario");
        }

        [AfterScenario("ConcatTag")]
        public static void AfterConcat()
        {
            Console.WriteLine("After scenario");
        }
    }
}
