using AutomationTest.BaseClass;
using AutomationTest.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace AutomationTest.PagesObject
{
    internal class SoftwareStorePage : BasePage
    {
        public SoftwareStorePage(IWebDriver? Driver) : base(Driver)
        {
            if (Driver != null)
                PageFactory.InitElements(Driver, this);

        }

        [FindsBy(How = How.XPath, Using = "//img[@alt='Antivirus']")]
        internal IWebElement? _antivirus = null;

        [FindsBy(How = How.XPath, Using = "//img[@alt='Elearning']")]
        internal IWebElement? _elearning = null;

        [FindsBy(How = How.XPath, Using = "//img[@alt='Enterprise software']")]
        internal IWebElement? _enterprise = null;

        [FindsBy(How = How.XPath, Using = "//img[@alt='Office']")]
        internal IWebElement? _office = null;

        /// <summary>
        /// Verify Top Categories
        /// </summary>
        public void VerifyTopCategories()
        {
            Assert.True(_antivirus?.VerifyElementDisplay(), " Antivirus image is not displayed ");
            Assert.True(_elearning?.VerifyElementDisplay(), " Elearning image is not displayed ");
            Assert.True(_enterprise?.VerifyElementDisplay(), " Enterprise image is not displayed ");
            Assert.True(_office?.VerifyElementDisplay(), " office image is not displayed ");
        }
    }
}
