using FacebookLoginSel.BaseClass;
using FacebookLoginSel.PageObject;
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
        [Test, Order(0)]
        public void LoginTest()
        {
            

            LoginPage login = new LoginPage(driver);
            login.GoToHomePage();

            string expectedPageTitle = "Facebook";
            string actualPageTitle = driver.Title;
            Console.WriteLine("Expected Title is:"+expectedPageTitle);
            Console.WriteLine("Actual Title is:"+actualPageTitle);
            Assert.AreEqual(expectedPageTitle, actualPageTitle);          



        }

        [Test, Order(1)]
        public void ArticleUploadTest()
        {

 

            ArticlePage article = new ArticlePage(driver);
            article.UploadThArticle();

           Assert.IsTrue(driver.FindElement(By.XPath("//img[@class='_s0 _4ooo _1x2_ _1ve7 _1gax img']")).Displayed);
            



        }



    }
}
    
