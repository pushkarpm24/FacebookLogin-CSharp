using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FacebookLoginSel.PageObject
{
    public class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        [FindsBy(How = How.XPath,Using = "//input[@id='email']")]
        public IWebElement EmailTextbox { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='pass']")]
        public IWebElement PassTextbox { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='loginbutton']")]
        public IWebElement LoginButton { get; set; }

        public void NavigateToHomePage()
        {
            EmailTextbox.SendKeys("pushkarmorey555@gmail.com");
            Thread.Sleep(1000);
            PassTextbox.SendKeys("pushkarpm2430");
            Thread.Sleep(1000);
            LoginButton.Click();
            Thread.Sleep(1000);

        }
    }
}
