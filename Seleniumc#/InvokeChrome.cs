using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace NunitTraning.Seleniumc_
{
    internal class InvokeChrome
    {

        IWebDriver driver;

        [SetUp]
        public void startbrowser()
        {
            //launch chrome 
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            //initialize the web driver
            driver = new FirefoxDriver();

        }
        [Test, Category("Sanity")]
        public void testcase1()
        {
            driver.Navigate().GoToUrl("https://www.google.com/search?client=firefox-b-d&q=what+is+interfaces%3F");
        }
        [TearDown]
        public void closebrowser()
        {
            driver.Close();
        }
    }
}
