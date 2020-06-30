using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FacebookLoginSel.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void Initilize()
        {
            //using chrome options to disable unwanted notifications
            ChromeOptions opt = new ChromeOptions();
            opt.AddArguments("--disable-notifications");

            //Launch the chrome browser
            driver = new ChromeDriver(opt);

            //Using implicitly wait 
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            //Maximizing the window
            driver.Manage().Window.Maximize();

            //Enter the url
            string facebookUrl = ConfigurationManager.AppSettings["url"];
            driver.Url = facebookUrl;
        }

        [OneTimeTearDown]
        public void Close()
        {
            Thread.Sleep(5000);
            driver.Quit();
            
        }
    }
}
