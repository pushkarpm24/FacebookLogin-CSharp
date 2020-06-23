using AutoIt;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FacebookLoginSel.Pages
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
        [FindsBy(How = How.XPath, Using = "//div[@class='_3jk']")]
        public IWebElement PhotoVideoButton;
        [FindsBy(How = How.XPath, Using = "//a[@class='__9u __9t']//div[@class='_3jk']")]
        public IWebElement ChooseFileButton;
        [FindsBy(How = How.XPath, Using = "//div[@class='_3-w4 _3-w6']")]
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
            Thread.Sleep(5000);

            PhotoVideoButton.Click();
            Thread.Sleep(3000);
            Process.Start("E:\\PhotoUploadScript");
            Thread.Sleep(3000);
            ChooseFileButton.Click();            
            Process.Start("E:\\PhotoUploadScript2");
            
            Thread.Sleep(10000);
            NewsFeedBox.Click();
            Thread.Sleep(3000);
            PostButton.Click();
            Thread.Sleep(20000);
            DropdownList.Click();
            Thread.Sleep(5000);
            LogoutButton.Click();
          
        }
    }
}
