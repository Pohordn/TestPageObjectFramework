using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_QA_project
{
    class CabinetAddressChangePage : Page
    {
        [FindsBy(How = How.CssSelector, Using = "input[value='Edit']")]
        private IWebElement editButton;

        [FindsBy(How = How.CssSelector, Using = "div.backlink>a")]
        private IWebElement backLink;

        internal CabinetAddressChangeFirstPage enterToAddressEdit()
        {
            CustomMethods.WaitUntilElementExists(this.editButton, 10);
            this.editButton.Click();
            return new CabinetAddressChangeFirstPage();
        }

        internal PaypalProfilePage enterBackToProfile()
        {
            backLink.Click();
            return new PaypalProfilePage();
        }
    }
}
