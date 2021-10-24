using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Katalon_Test
{
    [TestClass]
    class Test_Login
    {

        [TestMethod]
        public void TC1()
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

            IWebElement elementText = driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Giỏ hàng'])[1]/preceding::i[1]"));
            String text = elementText.Text;

            if (text == null)
            {
                Assert.Fail();
            }

            driver.Close();
        }

        [TestMethod]
        public void TC2_Failure()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://localhost:44368/");

            IWebElement elementAccount = driver.FindElement(By.XPath("//div[@id='hmenu']/ul/li[6]/a"));
            elementAccount.Click();

            IWebElement elementLogin = driver.FindElement(By.XPath("//div[@id='hmenu']/ul/li[6]/ul/li/a"));
            elementLogin.Click();

            IWebElement elementEmail = driver.FindElement(By.XPath("//input[@name='email']"));
            elementEmail.SendKeys("abc@gmail.com");

            IWebElement elementPassword = driver.FindElement(By.XPath("//input[@name='password']"));
            elementPassword.SendKeys("123");

            IWebElement elementRememberMe = driver.FindElement(By.XPath("//input[@name='remember']"));
            elementRememberMe.Click();

            IWebElement elementBtnLogin = driver.FindElement(By.XPath("//button[@type='submit']"));
            elementBtnLogin.Click();

            IWebElement elementText = driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Giỏ hàng'])[1]/preceding::i[1]"));
            String text = elementText.Text;

            Assert.AreEqual(text, "Tài khoản không tồn tại");

            driver.Close();
        }

        [TestMethod]
        public void TC3_Failure()
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
            elementPassword.SendKeys("123");

            IWebElement elementRememberMe = driver.FindElement(By.XPath("//input[@name='remember']"));
            elementRememberMe.Click();

            IWebElement elementBtnLogin = driver.FindElement(By.XPath("//button[@type='submit']"));
            elementBtnLogin.Click();

            IWebElement elementText = driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Giỏ hàng'])[1]/preceding::i[1]"));
            String text = elementText.Text;

            Assert.AreEqual(text, "Tài khoản không tồn tại");

            driver.Close();
        }

        [TestMethod]
        public void TC4_Failure()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://localhost:44368/");

            IWebElement elementAccount = driver.FindElement(By.XPath("//div[@id='hmenu']/ul/li[6]/a"));
            elementAccount.Click();

            IWebElement elementLogin = driver.FindElement(By.XPath("//div[@id='hmenu']/ul/li[6]/ul/li/a"));
            elementLogin.Click();

            IWebElement elementEmail = driver.FindElement(By.XPath("//input[@name='email']"));
            elementEmail.SendKeys("abc@gmail.com");

            IWebElement elementPassword = driver.FindElement(By.XPath("//input[@name='password']"));
            elementPassword.SendKeys("anatr");

            IWebElement elementRememberMe = driver.FindElement(By.XPath("//input[@name='remember']"));
            elementRememberMe.Click();

            IWebElement elementBtnLogin = driver.FindElement(By.XPath("//button[@type='submit']"));
            elementBtnLogin.Click();

            IWebElement elementText = driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Giỏ hàng'])[1]/preceding::i[1]"));
            String text = elementText.Text;

            Assert.AreEqual(text, "Tài khoản không tồn tại");

            driver.Close();
        }

    }
}
