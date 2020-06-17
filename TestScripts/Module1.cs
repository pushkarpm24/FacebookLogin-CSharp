using FacebookLoginSel.BaseClass;
using FacebookLoginSel.PageObject;
using NUnit.Framework;
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
        [Test]
        public void LoginTest()
        {
            LoginPage login = new LoginPage(driver);
            login.NavigateToHomePage();

            ArticlePage article = new ArticlePage(driver);
            article.NavigateToArticlePage();
        }
    }
}
