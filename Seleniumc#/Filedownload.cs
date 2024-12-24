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
    [Allure.NUnit.AllureNUnit]
    [Parallelizable(ParallelScope.All)]
    internal class Filedownload
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
            //launch application URL
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/download");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement download = driver.FindElement(By.XPath("//a[normalize-space()='1734472065.txt']"));
            download.Click();


            Thread.Sleep(1000);


            
            string download1 = @"C:\Users\apras\Desktop\New folder";



            if (File.Exists(download1))
            {
                Console.WriteLine("File is downloaded successfully.");
            }
            else
            {
                Console.WriteLine("File download failed.");
            }
            

        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
    }
