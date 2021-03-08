using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
namespace utemezestest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver dw = new FirefoxDriver();

            dw.Manage().Window.Maximize();

            dw.Navigate().GoToUrl("https://www.portfolio.hu/ingatlan/20210202/9-eves-rekord-brutalisan-erosen-kezdte-2021-et-a-lakaspiac-467878#");


        }
    }
}
