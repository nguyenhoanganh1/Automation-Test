using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace Code_Katalon_Test
{
    [TestClass]
    public class test_category
    {
        [TestMethod]
        public void Addcategory()
        {
            IWebDriver driver = new ChromeDriver();
            // mở to cửa sổ truy cập vào trang web
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://localhost:44368/");

            // vào tài khoản để đăng nhập - click tài khoản
            IWebElement elementAccount = driver.FindElement(By.XPath("//div[@id='hmenu']/ul/li[6]/a/span"));
            elementAccount.Click();


            // click tiếp vào đăng nhập
            IWebElement elementLogin = driver.FindElement(By.XPath("//div[@id='hmenu']/ul/li[6]/ul/li/a"));
            elementLogin.Click();


            // điền thông tin để đăng nhập
            IWebElement elementEmail = driver.FindElement(By.XPath("//input[@name='email']"));

            elementEmail.SendKeys("nghiemn@fpt.edu.vn");


            // mật khẩu
            IWebElement elementPassword = driver.FindElement(By.XPath("//input[@name='password']"));
            elementPassword.SendKeys("admin");

            // IWebElement elementRememberMe = driver.FindElement(By.XPath("//input[@name='remember']"));
            //elementRememberMe.Click();


            // nút đăng nhập
            IWebElement elementBtnLogin = driver.FindElement(By.XPath("//button[@type='submit']"));
            elementBtnLogin.Click();


            // click vào quản lí
            IWebElement element_quanli = driver.FindElement(By.XPath("//div[@id='hmenu']/ul/li/a"));
            element_quanli.Click();

            // click vào loại hàng hóa
            IWebElement elementLoaihanghoa = driver.FindElement(By.XPath("//div[@id='hmenu']/ul/li/ul/li[2]/a"));
            elementLoaihanghoa.Click();


            // click vào thêm mới
            IWebElement elementThemmoi = driver.FindElement(By.XPath("//a[contains(text(),'Tạo mới')]"));
            elementThemmoi.Click();


            // nhập tên tiếng anh
            IWebElement element_textbox_tentienganh = driver.FindElement(By.XPath("//input[@id='Name']"));
            element_textbox_tentienganh.SendKeys("GUN");


            // nhập tên tiếng việt
            IWebElement element_textbox_tenviet = driver.FindElement(By.XPath("//input[@id='NameVN']"));
            element_textbox_tenviet.SendKeys("Súng");



            // click nút create
            IWebElement element_Create = driver.FindElement(By.XPath("//input[@value='Create']"));
            element_Create.Click();

            driver.Close();
        }
    }
}
