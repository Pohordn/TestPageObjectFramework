using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_QA_project
{
    internal class CabinetAddressChangeFirstPage : Page
    {
        [FindsBy(How = How.CssSelector, Using = "input#address1")]
        private IWebElement address1Txt;

        [FindsBy(How = How.CssSelector, Using = "#edit_submit")]
        private IWebElement saveButton;

        internal void changeAddress(string address1)
        {
            address1Txt.Clear();
            address1Txt.SendKeys(address1);   
        }

        internal CabinetAddressChangePage clickOnSaveButton()
        {
            saveButton.Click();
            return new CabinetAddressChangePage();
        }
    }
}
