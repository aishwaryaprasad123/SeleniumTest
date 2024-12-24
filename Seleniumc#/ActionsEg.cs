using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NunitTraning.Seleniumc_
{
    internal class ActionsEg
    {

        IWebDriver driver;

      

        [SetUp]
        public void startBrowser()
        {
            //launch chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            //initialize the web driver
            driver = new EdgeDriver();
            driver.Manage().Window.Maximize();

        }
        [Test]
        public void testcase1()
        {
            //launch application URL
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            IWebElement primes = driver.FindElement(By.XPath("//a[@id='nav-link-amazonprime']"));
            Thread.Sleep(3000);
            IWebElement latestmovies = driver.FindElement(By.Id("(//img[@id='multiasins-img-link'])[1]"));

            new OpenQA.Selenium.Interactions.Actions(driver)
                .MoveToElement(primes)
                .ClickAndHold()
                .Pause(TimeSpan.FromSeconds(1))
                .MoveToElement(latestmovies)
                .Click()
                .Perform();
            Thread.Sleep(3000);

        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
