using AutomatinisTestavimas.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatinisTestavimas.Test
{
    class CheckBoxDemoTest
    {
        private static IWebDriver Driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Url = "https://www.seleniumeasy.com/test/basic-checkbox-demo.html";

            //WebDriverWait wait = new WebDriverWait(_Driver, TimeSpan.FromSeconds(10));

            //IWebElement popup = _Driver.FindElement(By.Id("at-cv-lightbox-close"));
            //wait.Until(e => e.FindElement(By.Id("at-cv-lightbox-close")).Displayed);
            //popup.Click();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            Driver.Close();
        }

        [Test]
        public static void CheckBoxDemo()
        {
            CheckBoxDemoInputPage page = new CheckBoxDemoInputPage(Driver);
            string Text = "Success - Check box is checked";
            bool result = true;
            Driver.FindElement(By.Id("isAgeSelected"));
            
            page.ClickOnSingleCheckboxDemoCheckbox();
            page.CheckSingleCheckboxDemoMessage(Text);
            page.ClickCheckbox1();
            page.ClickCheckbox2();
            page.ClickCheckbox3();
            page.ClickCheckbox4();
            page.ClickUncheckAll1();
            page.CheckIfbuttonSayUncheckAll(result);
            page.ClickUncheckAll();
        }
    }
}
