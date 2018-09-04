using NUnit.Framework;
using OnlineStoreToolsQA.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreToolsQA.TestCases
{
    class LogInTest
    {
        /*
        [Test]
        public void Test()
        {
            /*
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.store.demoqa.com";
            
            // Find the element that's ID attribute is 'account'(My Account) 
            driver.FindElement(By.XPath(".//*[@id='account']/a")).Click();

            // Find the element that's ID attribute is 'log' (Username)
            // Enter Username on the element found by above desc.
            driver.FindElement(By.Id("log")).SendKeys("testuser_1");

            // Find the element that's ID attribute is 'pwd' (Password)
            // Enter Password on the element found by the above desc.
            driver.FindElement(By.Id("pwd")).SendKeys("Test@123");

            // Now submit the form.
            driver.FindElement(By.Id("login")).Click();

            // Find the element that's ID attribute is 'account_logout' (Log Out)
            //driver.FindElement(By.XPath(".//*[@id='account_logout']/a")).Click();

            // Close the driver
            driver.Quit();
        }
        */
        
           

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();

            PropertiesCollection.driver.Navigate().GoToUrl("http://www.store.demoqa.com");

            PropertiesCollection.driver.Manage().Window.Maximize();

            Console.WriteLine("Opened URL and clicked Home Page");
        }

        [Test]
        public void Test()
        {

            HomePage accountPage = new HomePage();

            LoginPage loginAccount = accountPage.ClickMyAccout();

            loginAccount.SignIn("anu", "@nuK1978");

            Console.WriteLine("Successfully launched Home page and returned Login Page");
        }
    }
        
    
}
