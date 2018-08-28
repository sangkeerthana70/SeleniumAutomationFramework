using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreToolsQA.PageObjects
{
    public class LoginPage
    {

        [Obsolete("Use newMethod instead", false)]
        public LoginPage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        //private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "log")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.Id, Using = "pwd")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.ClassName, Using = "submit")]
        public IWebElement Login { get; set; }
    }
}
