using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using FacebookLoginSel.BaseClass;
using FacebookLoginSel.Pages;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FacebookLoginSel.TestScripts
{
    [TestFixture]
    public class Module1 : BaseTest
    {
        ExtentReports extent = null;
        //Screenshot ss = null;

        [OneTimeSetUp]
        public void ExtentStart()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\HP\source\repos\FacebookLoginSel\ExtentReports\Module1.html");
            extent.AttachReporter(htmlReporter);

        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }

        [Test, Order(0)]
        public void LoginTest()
        {
            ExtentTest test = extent.CreateTest("LoginTest").Info("Login Test Started");
                       
            LoginPage login = new LoginPage(driver);
            login.GoToHomePage();

            test.Log(Status.Info, "Login Done");

            string expectedPageTitle = "Facebook";
            string actualPageTitle = driver.Title;
            Console.WriteLine("Expected Title is:"+expectedPageTitle);
            Console.WriteLine("Actual Title is:"+actualPageTitle);          

            Assert.AreEqual(expectedPageTitle, actualPageTitle);


            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\HP\\source\\repos\\FacebookLoginSel\\ScreenShot\\one.png", ScreenshotImageFormat.Png);

        }

        [Test, Order(1)]
        public void ArticleUploadTest()
        {
            ExtentTest test = extent.CreateTest("ArticleUploadTes").Info("Article Upload Test Started");

            ArticlePage article = new ArticlePage(driver);
            article.UploadThArticle();
            test.Log(Status.Info, "Articles Get Uploaded Successfully");            

            Assert.IsTrue(driver.FindElement(By.XPath("//img[@class='_s0 _4ooo _1x2_ _1ve7 _1gax img']")).Displayed);

            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\HP\\source\\repos\\FacebookLoginSel\\ScreenShot\\one.png", ScreenshotImageFormat.Png);

        }         

    }
}
    
