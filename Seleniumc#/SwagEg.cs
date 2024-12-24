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
    internal class SwagEg
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            //launch chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig()); //*EdgeConfig*/ //FirefoxConfig
            //initialize the web driver
            driver = new FirefoxDriver(); 
        }
        [Test]
        public void testcase1()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");
            Thread.Sleep(1000);
            //username
            IWebElement UserName = driver.FindElement(By.XPath("//input[@id='user-name']"));
            UserName.SendKeys("standard_user");
            Thread.Sleep(1000);
            //password
            IWebElement Password = driver.FindElement(By.XPath("//input[@id='password']"));
            Password.SendKeys("secret_sauce");
            Thread.Sleep(1000);
            //login
            IWebElement Login = driver.FindElement(By.XPath("//input[@id='login-button']"));
            Login.Click();
            Thread.Sleep(3000);
            //product
            IWebElement Product = driver.FindElement(By.XPath("//div[@class='inventory_list']//div[1]//div[3]//button[1]"));
            Product.Click();
            Thread.Sleep(4000);
            //add to cart
            IWebElement Cart = driver.FindElement(By.XPath("(//*[name()='path'][@fill='currentColor'])[1]"));
            Cart.Click();
            Thread.Sleep(5000);
            //checkout
            IWebElement CheckOut = driver.FindElement(By.XPath("//a[normalize-space()='CHECKOUT']"));
            CheckOut.Click();
            Thread.Sleep(5000);
            //  //input[@id='first-name']

            IWebElement FirstName = driver.FindElement(By.XPath("//input[@id='first-name']"));
            FirstName.SendKeys("Aishwarya");
            Thread.Sleep(1000);
            //last name

            IWebElement LastName = driver.FindElement(By.XPath("//input[@id='last-name']"));
            LastName.SendKeys("Shetty");
            Thread.Sleep(1000);
            //postalcode
            IWebElement PostalCode = driver.FindElement(By.XPath("//input[@id='postal-code']"));
            PostalCode.SendKeys("1234");
            Thread.Sleep(1000);

         

            IWebElement Con = driver.FindElement(By.XPath("//input[@value='CONTINUE']"));
            Con.Click();
            Thread.Sleep(3000);

            IWebElement Finish = driver.FindElement(By.XPath("//a[normalize-space()='FINISH']"));
            Finish.Click();
            Thread.Sleep(1000);

        }

            [TearDown]
            public void closebrowser()
            {
                driver.Close();
            }
        
    }
}
