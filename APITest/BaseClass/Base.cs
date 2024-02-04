using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.BaseClass
{
    public class Base
    {
        protected IWebDriver? Driver;
        protected BasePage? CurrentPage;

        public Base() { }

        public Base(IWebDriver? Driver)
        {
            this.Driver = Driver;
        }

        /// <summary>
        /// Return Instence of Page
        /// </summary>
        /// <typeparam name="TPage"></typeparam>
        /// <returns></returns>
        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }
    }
}
