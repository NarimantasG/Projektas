using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace AutomatinisTestavimas.Page
{
    class CheckBoxDemoInputPage : BasePage
    {
        //private static IWebDriver _Driver;

        private IWebElement _clickOnThisCheckbox => Driver.FindElement(By.Id("isAgeSelected"));

        private IWebElement _checkBoxIsChecked => Driver.FindElement(By.Id("txtAge"));

        private IWebElement _checkBox1 => Driver.FindElement(By.CssSelector("#easycont > div > div.col-md-6.text-left > div:nth-child(5) > div.panel-body > div:nth-child(3) > label > input"));

        private IWebElement _checkBox2 => Driver.FindElement(By.CssSelector("#easycont > div > div.col-md-6.text-left > div:nth-child(5) > div.panel-body > div:nth-child(4) > label > input"));

        private IWebElement _checkBox3 => Driver.FindElement(By.CssSelector("#easycont > div > div.col-md-6.text-left > div:nth-child(5) > div.panel-body > div:nth-child(5) > label > input"));

        private IWebElement _checkBox4 => Driver.FindElement(By.CssSelector("#easycont > div > div.col-md-6.text-left > div:nth-child(5) > div.panel-body > div:nth-child(6) > label > input"));

        private IWebElement _uncheckAll => Driver.FindElement(By.Id("check1"));

        public CheckBoxDemoInputPage(IWebDriver webDriver) : base(webDriver)
        {
            Driver = webDriver;
            Driver.Url = "Http://www.seleniumeasy.com/test/basic-checkbox-demo.html";
        }
        
        public CheckBoxDemoInputPage ClickOnSingleCheckboxDemoCheckbox()
        {
            _clickOnThisCheckbox.Click();
            return this;
        }

        public void CheckSingleCheckboxDemoMessage(string Text)
        {
            Assert.AreEqual(Text,_checkBoxIsChecked.Text, "Text is different");
        }

        public void ClickCheckbox1()
        {
            _checkBox1.Click();
        }
        public void ClickCheckbox2()
        {
            _checkBox2.Click();
        }
        public void ClickCheckbox3()
        {
            _checkBox3.Click();
        }

        public void ClickCheckbox4()
        {
            _checkBox4.Click();
        }
        public void ClickUncheckAll1()
        {
            _uncheckAll.Click();
        }

        public void CheckIfbuttonSayUncheckAll(bool result)
        {
            Assert.AreEqual(_uncheckAll.Displayed, result, "Result is diffreant");
        }

        public void ClickUncheckAll()
        {
            _uncheckAll.Click();
        }

    }
}
