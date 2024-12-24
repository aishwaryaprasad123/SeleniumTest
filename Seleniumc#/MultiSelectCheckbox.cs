using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NunitTraning.Seleniumc_
{
    [Allure.NUnit.AllureNUnit]
    internal class MultiSelectCheckbox
    {
        IWebDriver driver;

        [SetUp]

        public void startBrowser()

        {

            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());

            //initialize the web driver

            driver = new EdgeDriver();

        }

        [Test, Category("Regression")]

        public void testcase1()

        {

            //launch application URL

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/checkboxes");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            //multi slect
            IWebElement CheckBox2 = driver.FindElement(By.XPath("//input[]2"));
            if (CheckBox2.Selected)
            {
                CheckBox2.Click();
                Thread.Sleep(5000);
            }


            // checkboxes can be single select and multi select
            IReadOnlyList<IWebElement> checkboxlist = driver.FindElements(By.XPath("//input[@type = 'checkbox']"));
            foreach (IWebElement e in checkboxlist)
            {
                // Console.WriteLine(e.Text);
                e.Click();
                Thread.Sleep(1000);
            }


        }

        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }
    }
}
