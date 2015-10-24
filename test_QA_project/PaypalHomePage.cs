using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_QA_project
{
    internal class PaypalHomePage : Page
    {
        [FindsBy(How = How.CssSelector, Using = "a#myaccount-button")]
        private IWebElement myPaypalButton;

        [FindsBy(How = How.CssSelector, Using = " div.header>p.links>a")]
        private IWebElement transactionButton;

        internal PaypalCabinetPage enterToMyCabinet() 
        {
            CustomMethods.WaitUntilElementExists(this.myPaypalButton, 10);
            myPaypalButton.Click();
            return new PaypalCabinetPage();
        }
        internal PaypalActivityPage enterToActivity()
        {
            CustomMethods.WaitUntilElementExists(this.transactionButton, 10);
            transactionButton.Click();
            return new PaypalActivityPage();
        }
    }
}
