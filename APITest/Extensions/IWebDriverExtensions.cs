using OpenQA.Selenium;
using System;

namespace AutomationTest.Extensions
{
    public static class IWebDriverExtensions
    {
        /// <summary>
        /// Click On Element Using JS
        /// </summary>
        /// <param name="Driver"></param>
        /// <param name="Element"></param>
        public static void ClickOnElement(this IWebDriver Driver, IWebElement Element)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].click();", Element);
        }

        /// <summary>
        /// Switch To NewW Browser Tab
        /// </summary>
        /// <param name="Driver"></param>
        /// <param name="WindowNumber"></param>
        public static void SwitchToNewWBrowserTab(this IWebDriver Driver, int WindowNumber)
        {
            var Counter = 0;
            foreach (var Handle in Driver.WindowHandles)
            {
                if (Counter == WindowNumber)
                {
                    Driver.SwitchTo().Window(Handle);
                    break;
                }
                Counter++;
            }
        }
    }
}
