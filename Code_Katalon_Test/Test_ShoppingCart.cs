using System;
using System.Threading;
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
        public void tc1()
        {
            IWebDriver driver = new ChromeDriver();
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

            driver.Navigate().GoToUrl("https://localhost:44368/shoppingcart/showcart?id=a");
            Assert.Fail();

            driver.Close();
        }
        [TestMethod]
        public void tc2()
        {
            IWebDriver driver = new ChromeDriver();
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
        public void tc6()
        {
            IWebDriver driver = new ChromeDriver();
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

            Thread.Sleep(1000);

            IAlert simpleAlert = driver.SwitchTo().Alert();
            simpleAlert.Accept();

            IWebElement elementAddToCart2 = driver.FindElement(By.XPath("//div[2]/div/button"));
            elementAddToCart2.Click();

            Thread.Sleep(1000);

            IAlert simpleAlert2 = driver.SwitchTo().Alert();
            simpleAlert2.Accept();

            IWebElement elementXemGioHang = driver.FindElement(By.XPath("//a[contains(text(),'Giỏ hàng')]"));
            elementXemGioHang.Click();

            driver.Close();
        }

        [TestMethod]
        public void tc7()
        {
            IWebDriver driver = new ChromeDriver();
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

            Thread.Sleep(1000);

            IAlert simpleAlert = driver.SwitchTo().Alert();
            simpleAlert.Accept();
            Console.WriteLine(simpleAlert);

            IWebElement elementAddToCart2 = driver.FindElement(By.XPath("//div[3]/div/div[3]/div/div[2]/div/button"));
            elementAddToCart2.Click();

            Thread.Sleep(1000);

            IAlert simpleAlert2 = driver.SwitchTo().Alert();
            simpleAlert2.Accept();
            Console.WriteLine(simpleAlert2);

            IWebElement elementXemGioHang = driver.FindElement(By.XPath("//a[contains(text(),'Giỏ hàng')]"));
            elementXemGioHang.Click();

            IWebElement elementQuantity = driver.FindElement(By.XPath("//li[@id='soluong']"));
            String text = elementQuantity.Text;

            Assert.AreEqual(text, "2");

            driver.Close();
        }

        [TestMethod]
        public void tc5()
        {
            IWebDriver driver = new ChromeDriver();
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
        public void tc4_Failure()
        {
            IWebDriver driver = new ChromeDriver();
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
        public void tc3_Failure()
        {
            IWebDriver driver = new ChromeDriver();
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
