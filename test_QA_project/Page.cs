using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace test_QA_project
{
    //The following class is abstract class for all our pages 
    //which includes methods that every page have to contain
    abstract internal class Page
    {
        internal string URL { get; private set; }
        internal string pageTitle { get; set; }

        internal Page()
        {
            PageFactory.InitElements(CustomMethods.webDriver, this);
            this.URL = "https://www.paypal.com/";
        }

    }
}
