using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.DevTools.V129.FedCm;


namespace NunitTraning.Seleniumc_
{
    internal class Locators
    {
        IWebDriver driver;

        [SetUp]
        public void startbrowser()
        {
            //launch chrome
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());

            driver = new EdgeDriver();

        }
        [Test]
        public void testcase1()
        //launch the application url
        {
            driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/register.php");
            Thread.Sleep(5000);
            IWebElement FirstName = driver.FindElement(By.Id("firstname"));
            FirstName.SendKeys("Aishwarya");
            Thread.Sleep(5000);
            //name
            IWebElement LastName = driver.FindElement(By.Id("lastname"));
            LastName.SendKeys("Shetty");
            Thread.Sleep(5000);

            IWebElement UserName = driver.FindElement(By.XPath("//input[@id='username']"));
            UserName.SendKeys("AS");
            Thread.Sleep(5000);


            IWebElement Password = driver.FindElement(By.XPath("//input[@id='password']"));
            Password.SendKeys("AS");
            Thread.Sleep(5000);



            IWebElement Backtologin = driver.FindElement(By.LinkText("Back to Login"));
            Backtologin.Click();
            Thread.Sleep(5000);



            //css selector
            IWebElement Elements = driver.FindElement(By.CssSelector("button[class='accordion-button']"));
            Elements.Click();
            
            //tag name
            IWebElement input = driver.FindElement(By.TagName("//input[1]"));
            input.SendKeys("abcd");
            Thread.Sleep(5000);

            //class
            //input[@class = 'form-control'])[1]

            IWebElement ClassName = driver.FindElement(By.ClassName("//input[@class = 'form-control'])[1]"));
            ClassName.SendKeys("abcd");
            Thread.Sleep(5000);
        }
        [TearDown]
        public void closebrowser()
        {
            driver.Close();   // it will close the opened browser session

            //driver.Quit();      it will close all the browser sessions
        }
    }
}
