using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace test_QA_project
{
    //Identify standart methods to be used in our system in this class
    static internal class CustomMethods
    {
        
        internal static IWebDriver webDriver { get; set; } 

        internal static void ClickOnTheElement(IWebElement webElement)
        {
            webElement.Click();
        }

        internal static void WaitUntilElementExists(IWebElement element,int seconds)
        {
            WebDriverWait wait = new WebDriverWait(CustomMethods.webDriver,TimeSpan.FromSeconds(seconds));
            wait.Until(a => element.Displayed);
            
        }
    }
}
