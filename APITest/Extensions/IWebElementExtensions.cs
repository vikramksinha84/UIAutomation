using OpenQA.Selenium;
using System;

namespace AutomationTest.Extensions
{
    public static class IWebElementExtensions
    {
        /// <summary>
        /// Verify Element Display
        /// </summary>
        /// <param name="WebElement"></param>
        /// <returns></returns>
        public static bool VerifyElementDisplay(this IWebElement WebElement)
        {
            bool flag = false;
            try
            {
                flag=WebElement.Displayed;
                return flag;
            }
            catch (NoSuchElementException)
            {

                return false;
            }
        }

        /// <summary>
        /// Get Text
        /// </summary>
        /// <param name="WebElement"></param>
        /// <returns></returns>
        public static string? GetText(this IWebElement WebElement)
        {
            try
            {
                var value = WebElement.Text;
                return value;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Set Text
        /// </summary>
        /// <param name="WebElement"></param>
        /// <param name="Value"></param>
        public static void SetText(this IWebElement WebElement, string Value)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Value))
                {

                    WebElement.Clear();
                    WebElement.SendKeys(Value);
                    WebElement.SendKeys(Keys.Enter);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
