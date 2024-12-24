using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.DevTools.V129.Network;

namespace NunitTraning.Seleniumc_
{
    internal class Alerts
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
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
            driver.Manage().Window.Maximize();
            //locators
            //ID
            Thread.Sleep(5000);
            IWebElement infoalert = driver.FindElement(By.XPath("(//input[@id='alertbtn'])[1]"));
            infoalert.Click();
            Thread.Sleep(5000);
            //handling information alert
            IAlert alt = driver.SwitchTo().Alert();
            //clicking on ok button
            alt.Accept();
            Thread.Sleep(5000);
            //Handling confirmational alerts
            IWebElement confalert = driver.FindElement(By.XPath("//input[@id='confirmbtn']"));
            confalert.Click();
            Thread.Sleep(5000);
            //clicking on cancel button
            alt.Dismiss();
            Thread.Sleep(5000);


        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
