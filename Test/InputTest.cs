﻿using AutomatinisTestavimas.Page;
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
    class InputTest
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            IWebElement popup = _driver.FindElement(By.Id("at-cv-lightbox-close"));
            wait.Until(e => e.FindElement(By.Id("at-cv-lightbox-close")).Displayed);
            popup.Click();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Close();
        }

        [Test]
        public static void TestInputField()
        {
            InputPage page = new InputPage(_driver);
            string text = "Penktadienis";

            page.InsertTextToInputField(text);
            page.ClickShowMessageButton();
            page.VerifyResult(text);
        }

    }
}
