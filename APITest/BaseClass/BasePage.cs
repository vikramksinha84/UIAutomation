using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.BaseClass
{
    public class BasePage : Base
    {
        public BasePage(IWebDriver? Driver) : base(Driver) { }
    }
}
