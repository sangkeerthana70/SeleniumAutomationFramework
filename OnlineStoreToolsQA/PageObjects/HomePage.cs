using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreToolsQA.PageObjects
{
    class HomePage
    {
        [Obsolete("Use newMethod instead", false)]
        public HomePage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        //private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "account")]
        public IWebElement MyAccount { get; set; }

        //method to click MyAccount tab
        public LoginPage ClickMyAccout()
        {
            MyAccount.Click();
            return new LoginPage();
        }
    }
}
