using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NunitTraning.Seleniumc_
{
    internal class BrowserCommands
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
        [Test]
        public void testcase1()
            //launch the applictaion url
        {
            
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login"); ;
              // get the title of the web page
            string title = driver.Title;
            Console.WriteLine(title);
            //get current url
            string currenturl = driver.Url;
            Console.WriteLine(currenturl);
            //get the page source or html code
            string pagesource = driver.PageSource;
            Console.WriteLine(pagesource);

        }
        [TearDown]
        public void closebrowser()
        {
            //it will close the opned browser session
            driver.Close();
            //it will close all the browser tabs
            //driver.Quit();
        }
    }
}
