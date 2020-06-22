using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
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

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement EmailTextbox;
        [FindsBy(How = How.Id, Using = "pass")]
        public IWebElement PassTextbox;
        [FindsBy(How = How.XPath, Using = "//*[@id='u_0_b']")]
        public IWebElement LoginButton;

        public void GoToHomePage()
        {
            EmailTextbox.SendKeys("pushkarmorey555@gmail.com");
            PassTextbox.SendKeys("pushkarpm2430");
            LoginButton.Click();
            Thread.Sleep(5000);

        }
    }
}
