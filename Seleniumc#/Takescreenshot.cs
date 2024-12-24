using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.Extensions;

namespace NunitTraning.Seleniumc_
{
    internal class Takescreenshot
    {

        IWebDriver driver;

        public object ScreenshotImageFormat { get; private set; }

        [SetUp]
        public void startBrowser()
        {
            //launch chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            //initialize the web driver
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();

        }
        [Test]
        public void testcase1()
        {
            //launch application URL
            //launch application URL
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/upload");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);



            Screenshot ss = driver.TakeScreenshot();

            string folderPath = "C:\\Users\\apras\\Desktop\\New folder";
            string fileName = "Screenshot_" + DateTime.Now.ToString("yyyy-MM-dd_HHmmss") + ".png";
            string fullPath = Path.Combine(folderPath, fileName);


            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }


            ss.SaveAsFile(fullPath);




        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
