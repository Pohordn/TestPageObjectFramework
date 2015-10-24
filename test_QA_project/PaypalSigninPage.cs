using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace test_QA_project
{
    internal class PaypalSigninPage : Page
    {
        [FindsBy(How = How.CssSelector, Using = "input#email")]
        private IWebElement emailTxt;

        [FindsBy(How = How.CssSelector, Using = "input#password")]
        private IWebElement passwordTxt;

        [FindsBy(How = How.CssSelector, Using = "button#btnLogin")]
        private IWebElement loginButton;

        internal PaypalHomePage logInWithCredentials(string email, string password)
        {
            this.emailTxt.SendKeys(email);
            this.passwordTxt.SendKeys(password);
            this.loginButton.Click();
            return new PaypalHomePage();
        }


    }
}
