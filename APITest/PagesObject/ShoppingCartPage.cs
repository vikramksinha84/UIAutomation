using AutomationTest.BaseClass;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace AutomationTest.PagesObject
{
    internal class ShoppingCartPage : BasePage
    {
        public ShoppingCartPage(IWebDriver? Driver) : base(Driver)
        {
            if (Driver != null)
                PageFactory.InitElements(Driver, this);

        }

        [FindsBy(How = How.XPath, Using = "//span[@class='a-truncate-cut']")]
        internal IList<IWebElement>? _addedItems = null;

        /// <summary>
        /// Validate Added ProductIn Cart
        /// </summary>
        /// <param name="expactedproductName"></param>
        public void ValidateAddedProductInCart(string expactedproductName)
        {
            string productName=String.Empty;
            bool flag= false;
            if (_addedItems != null)
                foreach (IWebElement element in _addedItems)
                {
                    productName = element.Text;
                    if (productName.Contains(expactedproductName))
                    {
                        flag = true;
                        break;
                    }
                   
                }
            Assert.True(flag, $"{productName} actual value not matched with expected value {expactedproductName}");
        }

    }
}
