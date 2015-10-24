using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_QA_project
{
    internal class PaypalProfilePage : Page
    {
        [FindsBy(How = How.CssSelector, Using = "#address div:last-child a")]
        private IWebElement addressUpdateButton;

        [FindsBy(How = How.CssSelector, Using = "#phone div:last-child a")]
        private IWebElement phoneUpdateButton;

        [FindsBy(How = How.CssSelector, Using = "div.logo>a")]
        private IWebElement logoHome;

        internal CabinetAddressChangePage enterToChangeAddress()
        {
            CustomMethods.WaitUntilElementExists(this.addressUpdateButton, 10);
            addressUpdateButton.Click();
            return new CabinetAddressChangePage();
        }

        internal CabinetPhoneChangePage enterToChangePhone()
        {
            CustomMethods.WaitUntilElementExists(this.phoneUpdateButton, 10);
            phoneUpdateButton.Click();
            return new CabinetPhoneChangePage();
        }

        internal PaypalHomePage enterHomePage()
        {
            this.logoHome.Click();
            return new PaypalHomePage();
        }
    }
}
