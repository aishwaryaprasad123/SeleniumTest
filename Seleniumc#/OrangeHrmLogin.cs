using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using System.Net.Http.Headers;
using NUnit.Framework;
using OpenQA.Selenium.Edge;

namespace NunitTraning.Seleniumc_
{
    internal class OrangeHrmLogin
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            //launch chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            //initialize the web driver
            driver = new EdgeDriver();
        }
        [Test]
        public void testcase1()
        {
            //launch application URL
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/index.html");
            //locators
            //ID
            Thread.Sleep(5000);
            IWebElement Username = driver.FindElement(By.XPath("//input[@id='user-name']"));
            Username.SendKeys("standard_user");
            IWebElement Password = driver.FindElement(By.XPath("//input[@id='password']"));
            Password.SendKeys("secret_sauce");
            IWebElement Login = driver.FindElement(By.XPath("//input[@id='login-button']"));
            Login.Click();
            Thread.Sleep(6000);
            IWebElement Products = driver.FindElement(By.XPath("//div[@class='product']"));
            /*
            // Displayed validation
            if (Products.Displayed)
            {
                Console.WriteLine("User is on the home page");
            }
            else
            {
 
                Console.WriteLine("User is not on the home page");
            }
            */
            // Assertion class valdiation
            string actualtext = Products.Text;
            string expectedvalue = "Products";
            Assert.AreEqual(actualtext, expectedvalue);
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

















    }
}
