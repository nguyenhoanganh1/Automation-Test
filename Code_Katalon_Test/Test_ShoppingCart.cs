using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace Code_Katalon_Test
{
    [TestClass]
    public class Test_ShoppingCart
    {
        [TestMethod]
        public void ShowInfoCart()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://localhost:44368/");

            IWebElement elementAccount = driver.FindElement(By.XPath("//div[@id='hmenu']/ul/li[6]/a"));
            elementAccount.Click();

            IWebElement elementLogin = driver.FindElement(By.XPath("//div[@id='hmenu']/ul/li[6]/ul/li/a"));
            elementLogin.Click();

            IWebElement elementEmail = driver.FindElement(By.XPath("//input[@name='email']"));
            elementEmail.SendKeys("anatr@gmail.com");

            IWebElement elementPassword = driver.FindElement(By.XPath("//input[@name='password']"));
            elementPassword.SendKeys("anatr");

            IWebElement elementRememberMe = driver.FindElement(By.XPath("//input[@name='remember']"));
            elementRememberMe.Click();

            IWebElement elementBtnLogin = driver.FindElement(By.XPath("//button[@type='submit']"));
            elementBtnLogin.Click();

            IWebElement elementXemGioHang = driver.FindElement(By.XPath("//a[contains(text(),'Giỏ hàng')]"));
            elementXemGioHang.Click();

            driver.Close();
        }
        [TestMethod]
        public void AddToCartSuccess()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://localhost:44368/");

            IWebElement elementAccount = driver.FindElement(By.XPath("//div[@id='hmenu']/ul/li[6]/a"));
            elementAccount.Click();

            IWebElement elementLogin = driver.FindElement(By.XPath("//div[@id='hmenu']/ul/li[6]/ul/li/a"));
            elementLogin.Click();

            IWebElement elementEmail = driver.FindElement(By.XPath("//input[@name='email']"));
            elementEmail.SendKeys("anatr@gmail.com");

            IWebElement elementPassword = driver.FindElement(By.XPath("//input[@name='password']"));
            elementPassword.SendKeys("anatr");

            IWebElement elementRememberMe = driver.FindElement(By.XPath("//input[@name='remember']"));
            elementRememberMe.Click();

            IWebElement elementBtnLogin = driver.FindElement(By.XPath("//button[@type='submit']"));
            elementBtnLogin.Click();

            IWebElement elementAddToCart = driver.FindElement(By.XPath("//div[2]/div/button"));
            elementAddToCart.Click();

            driver.Close();
        }
        [TestMethod]
        public void AddToCartFailure1()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://localhost:44368/");

            IWebElement elementAccount = driver.FindElement(By.XPath("//div[@id='hmenu']/ul/li[6]/a"));
            elementAccount.Click();

            IWebElement elementLogin = driver.FindElement(By.XPath("//div[@id='hmenu']/ul/li[6]/ul/li/a"));
            elementLogin.Click();

            IWebElement elementEmail = driver.FindElement(By.XPath("//input[@name='email']"));
            elementEmail.SendKeys("anatr@gmail.com");

            IWebElement elementPassword = driver.FindElement(By.XPath("//input[@name='password']"));
            elementPassword.SendKeys("anatr");

            IWebElement elementRememberMe = driver.FindElement(By.XPath("//input[@name='remember']"));
            elementRememberMe.Click();

            IWebElement elementBtnLogin = driver.FindElement(By.XPath("//button[@type='submit']"));
            elementBtnLogin.Click();

            driver.Navigate().GoToUrl("https://localhost:44368/shoppingcart/additem?id=abc");
            Assert.Fail();

            driver.Close();
        }

        [TestMethod]
        public void AddToCartFailure2()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://localhost:44368/");

            IWebElement elementAccount = driver.FindElement(By.XPath("//div[@id='hmenu']/ul/li[6]/a"));
            elementAccount.Click();

            IWebElement elementLogin = driver.FindElement(By.XPath("//div[@id='hmenu']/ul/li[6]/ul/li/a"));
            elementLogin.Click();

            IWebElement elementEmail = driver.FindElement(By.XPath("//input[@name='email']"));
            elementEmail.SendKeys("anatr@gmail.com");

            IWebElement elementPassword = driver.FindElement(By.XPath("//input[@name='password']"));
            elementPassword.SendKeys("anatr");

            IWebElement elementRememberMe = driver.FindElement(By.XPath("//input[@name='remember']"));
            elementRememberMe.Click();

            IWebElement elementBtnLogin = driver.FindElement(By.XPath("//button[@type='submit']"));
            elementBtnLogin.Click();

            driver.Navigate().GoToUrl("https://localhost:44368/shoppingcart/additem?id=1000a");
            Assert.Fail();

            driver.Close();
        }

        [TestMethod]
        public void AddToCartFailure3()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://localhost:44368/");

            IWebElement elementAccount = driver.FindElement(By.XPath("//div[@id='hmenu']/ul/li[6]/a"));
            elementAccount.Click();

            IWebElement elementLogin = driver.FindElement(By.XPath("//div[@id='hmenu']/ul/li[6]/ul/li/a"));
            elementLogin.Click();

            IWebElement elementEmail = driver.FindElement(By.XPath("//input[@name='email']"));
            elementEmail.SendKeys("anatr@gmail.com");

            IWebElement elementPassword = driver.FindElement(By.XPath("//input[@name='password']"));
            elementPassword.SendKeys("anatr");

            IWebElement elementRememberMe = driver.FindElement(By.XPath("//input[@name='remember']"));
            elementRememberMe.Click();

            IWebElement elementBtnLogin = driver.FindElement(By.XPath("//button[@type='submit']"));
            elementBtnLogin.Click();

            driver.Navigate().GoToUrl("https://localhost:44368/shoppingcart/additem?id=-100");
            Assert.Fail();

            driver.Close();
        }
        [TestMethod]
        public void AddToCartFailure4()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://localhost:44368/");

            IWebElement elementAccount = driver.FindElement(By.XPath("//div[@id='hmenu']/ul/li[6]/a"));
            elementAccount.Click();

            IWebElement elementLogin = driver.FindElement(By.XPath("//div[@id='hmenu']/ul/li[6]/ul/li/a"));
            elementLogin.Click();

            IWebElement elementEmail = driver.FindElement(By.XPath("//input[@name='email']"));
            elementEmail.SendKeys("anatr@gmail.com");

            IWebElement elementPassword = driver.FindElement(By.XPath("//input[@name='password']"));
            elementPassword.SendKeys("anatr");

            IWebElement elementRememberMe = driver.FindElement(By.XPath("//input[@name='remember']"));
            elementRememberMe.Click();

            IWebElement elementBtnLogin = driver.FindElement(By.XPath("//button[@type='submit']"));
            elementBtnLogin.Click();

            driver.Navigate().GoToUrl("https://localhost:44368/shoppingcart/additem?id=");
            Assert.Fail();

            driver.Close();
        }
    }
}
