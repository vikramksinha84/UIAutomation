using AutomationTest.BaseClass;
using AutomationTest.Extensions;
using AutomationTest.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace AutomationTest.PagesObject
{
    internal class AmazonHomePage : BasePage
    {
        public AmazonHomePage(IWebDriver? Driver) : base(Driver)
        {
            if(Driver!=null)
            PageFactory.InitElements(Driver, this);

        }

        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        internal IWebElement? _searchtextbox = null;

        [FindsBy(How = How.XPath, Using = "//a[@id='nav-logo-sprites']")]
        internal IWebElement? _amazonlogo = null;

        [FindsBy(How = How.XPath, Using = "//div[@class='a-section a-spacing-small a-spacing-top-small']//span[3]")]
        internal IWebElement? _searchtextResult = null;

        [FindsBy(How = How.XPath, Using = "//a[@id='nav-hamburger-menu']")]
        internal IWebElement? _hamburger = null;

        [FindsBy(How = How.XPath, Using = "//div[text()='Mobiles, Computers']")]
        internal IWebElement? _shopMobComp = null;

        [FindsBy(How = How.XPath, Using = "//a[text()=' Software ']")]
        internal IWebElement? _software = null;

        [FindsBy(How = How.XPath, Using = "//div[@id='nav-cart-count-container']")]
        internal IWebElement? _addCart = null;

        /// <summary>
        /// Search Item in hoem page
        /// </summary>
        /// <param name="searchtext"></param>
        public void SearchItem(string searchtext)
        {
            _searchtextbox?.SetText(searchtext);
        }

        /// <summary>
        /// Verify Amazon logo
        /// </summary>
        public void VerifyAmazonlogo()
        {
            Assert.True(_amazonlogo?.VerifyElementDisplay(), $" Amazon logo is not displayed ");
        }

        /// <summary>
        /// Validate Searched Item
        /// </summary>
        /// <param name="expectedSearchedElementName"></param>
        public void ValidateSearchedItem(string expectedSearchedElementName)
        {
            string? actualSearchedElementName= _searchtextResult?.GetText();
            Assert.True(actualSearchedElementName?.Contains(expectedSearchedElementName, StringComparison.OrdinalIgnoreCase), $"{expectedSearchedElementName} actual value not matched with expected value {expectedSearchedElementName}");        
        }

        /// <summary>
        /// CLick On Hamburger
        /// </summary>
        public void CLickOnHamburger()
        {
            Thread.Sleep(1000);
            _hamburger?.Click();
        }

        /// <summary>
        /// Click MobilesComputers
        /// </summary>
        public void ClickMobilesComputers()
        {
            Thread.Sleep(1000);
            _shopMobComp?.Click();
        }

        /// <summary>
        /// Click Software
        /// </summary>
        /// <returns></returns>
        public SoftwareStorePage ClickSoftware()
        {
            Thread.Sleep(1000);
            if(_software!=null)
            Driver?.ClickOnElement(_software);
            return new SoftwareStorePage(Driver);
        }

        /// <summary>
        /// Get Toy Page
        /// </summary>
        /// <returns></returns>
        public ToyPage GetToyPage()
        {
            _searchtextbox?.SetText("Toy");
            return new ToyPage(Driver);
        }

        /// <summary>
        /// Click On Cart
        /// </summary>
        /// <returns></returns>
        public ShoppingCartPage ClickOnCart() {
            _addCart?.Click();
            return new ShoppingCartPage(Driver);
        }
    }
}
