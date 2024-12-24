using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Firefox;

namespace NunitTraning.Seleniumc_
{
    [Allure.NUnit.AllureNUnit]
    internal class KeyboardEvents
    {
        IWebDriver driver;



        [SetUp]
        public void startBrowser()
        {
            //launch chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            //initialize the web driver
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();

        }
        [Test, Category("Regression")]
        public void testcase1()
        {
            //launch application URL
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement password = driver.FindElement(By.Id("pass"));
            Thread.Sleep(5000);
            new Actions(driver)
                .MoveToElement(password).Click()
                .KeyDown(Keys.Shift)
                .SendKeys("aishwarya")
                .Perform();

        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
