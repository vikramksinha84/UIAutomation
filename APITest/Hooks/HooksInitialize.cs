using AutomationTest.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using AutomationTest.PagesObject;
using OpenQA.Selenium.Chrome;

namespace AutomationTest.Hooks
{
    [Binding]
    public class HooksInitialize
    {
        
        public HooksInitialize() 
        {
        }

        [BeforeTestRun]
        public static void TestRun()
        {
            //to do
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            //to do
        }

        [BeforeScenario]
        public void TestInitalize()
        {
        }

        [AfterScenario]
        public void AfterScenario()
        {

        }


        [AfterTestRun]
        public static void TearDownReport()
        {
            //to do
        }
    }
}
