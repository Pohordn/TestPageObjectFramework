using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace test_QA_project
{
    internal class PaypalStartPage : Page
    {

        [FindsBy(How = How.Id, Using = "ul-btn")]
        private IWebElement logInButton;

        [FindsBy(How = How.Id, Using = "signup-button")]
        private IWebElement signupButton;

        internal PaypalSigninPage loginToPaypal()
        {
            this.logInButton.Click();
            return new PaypalSigninPage();
        }
        
    }
}
