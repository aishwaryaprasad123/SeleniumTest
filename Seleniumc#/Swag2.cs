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
    internal class Swag2
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            //launch chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig()); /*EdgeConfig*/ //FirefoxConfig
            //initialize the web driver
            driver = new FirefoxDriver(); /*EdgeDriver()*/  //FirefoxDriver
        }
        [Test]
        public void testcase1()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");
            Thread.Sleep(1000);
            //xpath
            IWebElement UserName = driver.FindElement(By.XPath("//input[@id='user-name']"));
            UserName.SendKeys("standard_user");
            Thread.Sleep(1000);
            //password
            IWebElement Password = driver.FindElement(By.XPath("//input[@name='password']"));
            Password.SendKeys("secret_sauce");
            Thread.Sleep(1000);

            //Link text
            IWebElement Login = driver.FindElement(By.XPath("//input[@id='login-button']"));
            Login.Click();
            Thread.Sleep(1000);

            IWebElement Products = driver.FindElement(By.XPath("//div[@class='inventory_list']//div[1]//div[3]//button[1]"));
            Products.Click();
            Thread.Sleep(2000);

            IWebElement shopping_cart = driver.FindElement(By.XPath(" //a[@class='shopping_cart_link fa-layers fa-fw']//*[name()='svg']"));
            shopping_cart.Click();
            Thread.Sleep(5000);

            IWebElement checkout = driver.FindElement(By.XPath("//a[normalize-space()='CHECKOUT']"));
            checkout.Click();
            Thread.Sleep(5000);

            IWebElement firstname = driver.FindElement(By.XPath("//input[@id='first-name']"));
            firstname.SendKeys("Aish");
            Thread.Sleep(2000);

            IWebElement lastname = driver.FindElement(By.XPath("//input[@id='last-name']"));
            lastname.SendKeys("hh");
            Thread.Sleep(1000);

            IWebElement zipcode = driver.FindElement(By.XPath("//input[@id='postal-code']"));
            zipcode.SendKeys("678456");
            Thread.Sleep(3000);

            IWebElement cont = driver.FindElement(By.XPath("//input[@value='CONTINUE']"));
            cont.Click();
            Thread.Sleep(4000);

            IWebElement finish = driver.FindElement(By.XPath(" //a[normalize-space()='FINISH']"));
            finish.Click();
            Thread.Sleep(5000);

            string expected = "THANK YOU FOR YOUR ORDER";
            IWebElement actualtext = driver.FindElement(By.XPath("//h2[normalize-space()='THANK YOU FOR YOUR ORDER']"));
            Assert.That(expected, Is.EqualTo(actualtext.Text));
            Console.WriteLine($"{actualtext.Text} matches {expected}.");
            Thread.Sleep(3000);


        }
        [TearDown]
        public void closebrowser()
        {
            driver.Close();
        }
    }
}
