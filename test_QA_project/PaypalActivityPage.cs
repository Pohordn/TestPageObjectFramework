using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_QA_project
{
    internal class PaypalActivityPage : Page
    {
        [FindsBy(How = How.CssSelector, Using = "span.field input#from_date")]
        private IWebElement dateFromTxt;

        [FindsBy(How = How.CssSelector, Using = "span.field input#to_date")]
        private IWebElement dateToTxt;

        [FindsBy(How = How.CssSelector, Using = "input#show")]
        private IWebElement showBtn;
  
        internal PaypalOperationsPage getOperationsForPeriod(string dateFrom, string dateTo)
        {
            CustomMethods.WaitUntilElementExists(this.dateFromTxt, 10);
            dateFromTxt.Clear();
            dateFromTxt.SendKeys(dateFrom);
            dateToTxt.Clear();
            dateToTxt.SendKeys(dateTo);
            showBtn.Click();
            return new PaypalOperationsPage();
        }
    }
}
