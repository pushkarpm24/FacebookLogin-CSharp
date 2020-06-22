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

        [FindsBy(How = How.XPath, Using = "//a[@class='_7kfu']")]
        public IWebElement WriteSomethingBox;
        [FindsBy(How = How.XPath, Using = "//a[@class='_7kfu']")]
        public IWebElement EnterSomethingInBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='_26c-']")]
        public IWebElement NewsFeedBox;
        [FindsBy(How = How.XPath, Using = "//button[@class='_1mf7 _4r1q _4jy0 _4jy3 _4jy1 _51sy selected _42ft']")]
        public IWebElement PostButton;
        [FindsBy(How = How.Id, Using = "userNavigationLabel")]
        public IWebElement DropdownList;
        [FindsBy(How = How.XPath, Using = "//li[@class='_54ni navSubmenu _6398 _64kz __MenuItem']")]
        public IWebElement LogoutButton;


        public void UploadThArticle()
        {
         
            WriteSomethingBox.Click();
            Thread.Sleep(3000);
            EnterSomethingInBox.SendKeys("ppushkarpm.... This is my First selenium script...");
            Thread.Sleep(3000);
            NewsFeedBox.Click();
            Thread.Sleep(3000);
            PostButton.Click();
            Thread.Sleep(3000);
            DropdownList.Click();
            Thread.Sleep(5000);
            LogoutButton.Click();
           

        }
    }
}
