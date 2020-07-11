using AventStack.ExtentReports;
using AventStack.ExtentReports.Configuration;
using AventStack.ExtentReports.Reporter;
using FacebookLoginSel.BaseClass;
using FacebookLoginSel.Pages;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net.Config;
using System.Net.Mail;

namespace FacebookLoginSel.TestScripts
{
    [TestFixture]
    public class Module1 : BaseTest
    {
        ExtentReports extent = null;
        
        //applied logger in console
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

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
            login.GoToHomePage("LogInTest");

            test.Log(Status.Info, "Login Done");

            //verifying login
            string expectedPageTitle = "Facebook";
            string actualPageTitle = driver.Title;
            Console.WriteLine("Expected Title is:"+expectedPageTitle);
            Console.WriteLine("Actual Title is:"+actualPageTitle);          

            Assert.AreEqual(expectedPageTitle, actualPageTitle);
            log.Info("login verification successfull");

            //taking screenshot anfter login
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\HP\\source\\repos\\FacebookLoginSel\\ScreenShot\\Two.png", ScreenshotImageFormat.Png);

            //sending email
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
            mail.From = new MailAddress("moreypushkar24@outlook.com");
            mail.To.Add("moreypushkar24@outlook.com");
            mail.Subject = "Test Mail....";
            mail.Body = "Mail With Attachment";


            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment("C:/Users/HP/source/repos/FacebookLoginSel/ExtentReports/index.html");
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("moreypushkar24@outlook.com", "pushkaru24");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }

        [Test, Order(1)]
        public void ArticleUploadTest()
        {
            ExtentTest test = extent.CreateTest("ArticleUploadTes").Info("Article Upload Test Started");

            ArticlePage article = new ArticlePage(driver);
            article.UploadThArticle();
            test.Log(Status.Info, "Articles Get Uploaded Successfully");            

            //verifying logout
            Assert.IsTrue(driver.FindElement(By.XPath("//img[@class='_s0 _4ooo _1x2_ _1ve7 _1gax img']")).Displayed);
            log.Info("Logout verification successfull");
            
            //taking screenshot
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\HP\\source\\repos\\FacebookLoginSel\\ScreenShot\\one.png", ScreenshotImageFormat.Png);
        }         
        
    }
}
    
