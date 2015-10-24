using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Xml;
using System.IO;
using System.Threading;
using System.Collections;


 /* Don't forget to add your credentials for PayPal account in the CredentialsToUse.xml */
namespace test_QA_project
{
    [TestFixture(Category = "testFromTheTask", Description = "Task n.4 for QA vacancy")]
    [Category("testFromTheTask")]
    public class FromTheTaskTest
    {
        private string email;
        private string password;

        [SetUp]
        public void initialize()
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            XmlDocument doc = new XmlDocument();

            try
            {
                //Get the credentials from the CredentialsToUse.xml file it is in <project>/bin/Debug folder 
                doc.Load(startupPath + "../../../CredentialsToUse.xml");
                email = doc.SelectNodes("//email").Item(0).InnerText;
                password = doc.SelectNodes("//password").Item(0).InnerText;
            }

            catch (FileNotFoundException ex) {
                Console.WriteLine(ex.Message + "\n File with credentials wasn't found! Assign variables explicitly");  
            }

            catch (TypeLoadException ex)
            {
                Console.WriteLine(ex.Message + "\n File with credentials wasn't load! Wrong format? Assign variables explicitly");    
            }
            
            if (String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(password))
            {
                //If you don't use an xml file assign your data to varibles email and password expilicitly
                email = "enter email";
                password = "enter password";
            }

            CustomMethods.webDriver = new FirefoxDriver();
        }

        [Test]
        public void taskTest()
        {
            CustomMethods.webDriver.Navigate().GoToUrl("https://www.paypal.com/");
            PaypalStartPage startPage = new PaypalStartPage();
            PaypalSigninPage signInPage = startPage.loginToPaypal();
            //Next tab key sending is purposed to avoid silverlight pop-up browser built-in addon
            CustomMethods.webDriver.FindElements(By.CssSelector("*"))[0].SendKeys(Keys.Tab);
            signInPage.logInWithCredentials(email, password)
                .enterToMyCabinet()
                .enterToProfile()
                .enterToChangeAddress()
                .enterToAddressEdit()
                .changeAddress("address_new");
            (new CabinetAddressChangeFirstPage())
                .clickOnSaveButton()
                .enterBackToProfile()
                .enterToChangePhone()
                .enterToPhoneEdit()
                .changePhone("966856496");
            (new CabinetPhoneChangeFirstPage())
                .clickOnSaveButton()
                .enterBackToProfile()
                .enterHomePage()
                .enterToActivity()
                .getOperationsForPeriod("01/01/2015", "15/01/2015");                  
        }
    }
}
