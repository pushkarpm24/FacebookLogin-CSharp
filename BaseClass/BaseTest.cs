using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FacebookLoginSel.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void Open()
        {
            ChromeOptions opt = new ChromeOptions();
            opt.AddArguments("--disable-notifications");

            driver = new ChromeDriver(opt);            
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";

        }

        [TearDown]
        public void Close()
        {
            Thread.Sleep(30000);
            driver.Quit();
            
        }
    }
}
