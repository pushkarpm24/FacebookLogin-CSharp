using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FacebookLoginSel.PageObject
{
    class ArticlePage
    {

        IWebDriver driver;
        public ArticlePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = " / html / body")]
        public IWebElement WriteSomethingBox  { get; set; }
        [FindsBy(How = How.XPath, Using = " / html / body")]
        public IWebElement EnterSmoethingInBox { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@class='_1mf7 _4r1q _4jy0 _4jy3 _4jy1 _51sy selected _42ft']")]
        public IWebElement PostButton { get; set; }

        public void NavigateToArticlePage()
        {
            Thread.Sleep(1000);
            WriteSomethingBox.Click();
            Thread.Sleep(5000);
            EnterSmoethingInBox.SendKeys("pushkarpm.... This is my First selenium script...");
            Thread.Sleep(40000);
            PostButton.Click();
        }
    }
}
