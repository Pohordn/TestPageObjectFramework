using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_QA_project
{
    class PaypalCabinetPage : Page
    {
        [FindsBy(How = How.CssSelector, Using = "#navPrimary > ul.secondary > li.active > ul > li:last-child > a")]
        private IWebElement profileButton;

        internal PaypalProfilePage enterToProfile()
        {
            profileButton.Click();
            return new PaypalProfilePage();
        }
    }
}
