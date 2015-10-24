using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_QA_project
{
    internal class CabinetPhoneChangePage : Page
    {
        [FindsBy(How = How.CssSelector, Using = "span.col input[value='Edit']")]
        private IWebElement editButton;

        [FindsBy(How = How.CssSelector, Using = "div.backlink>a")]
        private IWebElement backLink;

        internal CabinetPhoneChangeFirstPage enterToPhoneEdit()
        {
            CustomMethods.WaitUntilElementExists(this.editButton, 10);
            editButton.Click();
            return new CabinetPhoneChangeFirstPage();
        }

        internal PaypalProfilePage enterBackToProfile()
        {
            CustomMethods.WaitUntilElementExists(this.backLink, 10);
            backLink.Click();
            return new PaypalProfilePage();
        }
    }
}
