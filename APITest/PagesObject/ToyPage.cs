using AutomationTest.BaseClass;
using AutomationTest.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.PagesObject
{
    internal class ToyPage : BasePage
    {
        public ToyPage(IWebDriver? Driver) : base(Driver)
        {
            if (Driver != null)
                PageFactory.InitElements(Driver, this);

        }

        [FindsBy(How = How.XPath, Using = "//span[@data-component-type='s-product-image']//a[1]//img[1]")]
        internal IList<IWebElement>? _toySearchedItem = null;

        [FindsBy(How = How.XPath, Using = "//span[@id='productTitle']")]
        internal IWebElement? _productTitle = null;

        [FindsBy(How = How.XPath, Using = "//input[@id='add-to-cart-button']")]
        internal IWebElement? _addCartButton = null;

        /// <summary>
        /// Click FirstI Toytem
        /// </summary>
        public void ClickFirstToyItem()
        {
            if(_toySearchedItem!=null)
            foreach (IWebElement element in _toySearchedItem)
            {
                    var prodyctName = element.Text;
                    element.Click();
                    break;
            }
        }

        /// <summary>
        /// Get Toy Detail Name
        /// </summary>
        /// <returns></returns>
        public string? GetToyDetailName()
        {
            if (Driver != null)
            {
                Driver.SwitchToNewWBrowserTab(1);            
            }    
            return _productTitle?.GetText();
        }

        /// <summary>
        /// Click On Add Cart
        /// </summary>
        public void ClickOnAddCart()
        {
            _addCartButton?.Click();
        }


    }
}
