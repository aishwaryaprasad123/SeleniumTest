using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using System.Configuration;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using NunitTraning.Seleniumc_;

namespace NunitTraning.Utilites
{
    public class Base
    {
        public IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            string browserName = System.Configuration.ConfigurationManager.AppSettings["browser"];
            InitBrowser(browserName);
            //launch the application
            //driver.Navigate().GoToUrl("https://www.google.com/search?client=firefox-b-d&q=what+is+interfaces%3F");
            //driver.Manage().Window.Maximize();

        }
        public void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                 
                    driver = new FirefoxDriver();
                    DropDownHandling obj = new DropDownHandling();
                    break;

                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

                    driver = new ChromeDriver();
                    break;

                case "Edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());

                    driver = new EdgeDriver();
                    break;


            }



        }

        [TearDown]
        public void TearBrowser()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
                driver = null;
            }
        }


    }
}
