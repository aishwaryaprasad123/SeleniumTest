﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;

namespace NunitTraning.Seleniumc_
{
    [Allure.NUnit.AllureNUnit]
    [Parallelizable(ParallelScope.All)]
    internal class WindowHandling
    {
        IWebDriver driver;

        public object Windowhandles { get; private set; }

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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/windows");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            // fecth the parent window handle 
            string parenthandle = driver.CurrentWindowHandle;
            Console.WriteLine(parenthandle);
            Thread.Sleep(1000);
            IWebElement clickhere = driver.FindElement(By.XPath("//a[normalize-space()='Click Here']"));
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            clickhere.Click();
            Thread.Sleep(1000);
            // fecth the window handles of all the windows - two windows are opened
            IList<string> windowhandles = new List<string>(driver.WindowHandles);
            // move the control to child window
            driver.SwitchTo().Window(windowhandles[1]);
            string title = driver.Title;
            Console.WriteLine(title);
            driver.Close();

            Thread.Sleep(1000);
            driver.SwitchTo().Window(windowhandles[0]);
            string parenttitle = driver.Title;
            Console.WriteLine(parenttitle);
            Assert.AreEqual("The Internet", parenttitle);


        }
        [TearDown]
        public void closeBrowser()
        {
            
            driver.Close();
        }

    }
}
