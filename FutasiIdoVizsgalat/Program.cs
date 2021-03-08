using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FutasiIdoVizsgalat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assert.IsTrue(false);
            IWebDriver dw = new FirefoxDriver();

            dw.Manage().Window.Maximize();

            dw.Navigate().GoToUrl("https://www.portfolio.hu/ingatlan/20210202/9-eves-rekord-brutalisan-erosen-kezdte-2021-et-a-lakaspiac-467878#");

            var Stopper = Stopwatch.StartNew();

            string keresendo = "A Duna House szakemberei szerint az";

            Assert.IsTrue(dw.FindElement(By.TagName("body")).Text.Contains(keresendo));
            Stopper.Stop();
            var valtozo = Stopper.ElapsedMilliseconds / 1000.0;

            Console.WriteLine("Masodpercben a futas "+ valtozo);

            Stopper = Stopwatch.StartNew();
            ((IJavaScriptExecutor)dw).ExecuteScript("document. getElementsByTagName('body')[0].value = arguments[0];", keresendo);
            Stopper.Stop();
            var elapsedSec = Stopper.ElapsedMilliseconds / 1000.0;
            Console.WriteLine("A masodik futas "+ elapsedSec);

        }
    }
}
