using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_QA_project
{
    internal class CabinetPhoneChangeFirstPage : Page
    {
        [FindsBy(How = How.CssSelector, Using = "input#O_PhoneNumber")]
        private IWebElement phoneTxt;

        [FindsBy(How = How.CssSelector, Using = "p.buttons>input[value='Save']")]
        private IWebElement saveButton;

        internal void changePhone(string phone)
        {
            phoneTxt.Clear();
            phoneTxt.SendKeys(phone);   
        }

        internal CabinetPhoneChangePage clickOnSaveButton()
        {
            saveButton.Click();
            return new CabinetPhoneChangePage();
        }
        
    }
}
