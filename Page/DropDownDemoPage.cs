using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace AutomatinisTestavimas.Page
{
    public class DropDownDemoPage : BasePage
    {
        private const string PageAddress = "https://www.seleniumeasy.com/test/basic-select-dropdown-demo.html";
        private const string ResultTextStatic = "Day selected :- ";

        private SelectElement _dropDown => new SelectElement(Driver.FindElement(By.Id("select-demo")));

        IWebElement _resultText => Driver.FindElement(By.CssSelector("#easycont > div > div.col-md-6.text-left > div:nth-child(4) > div.panel-body > p.selected-value"));

        private SelectElement _multiDropdown => new SelectElement(Driver.FindElement(By.Id("select-demo")));

        private IWebElement _firstSelectedButton => Driver.FindElement(By.Id("PrintMe"));
        private IWebElement _getAllSelectedButton => Driver.FindElement(By.Id("printAll"));
        private IWebElement _multiDropDownResult => Driver.FindElement(By.CssSelector("#easycont > div > div.col-md-6.text-left > div:nth-child(4) > div.panel-body > p.selected-value"));
        public DropDownDemoPage(IWebDriver webDriver) : base(webDriver) { }

        public DropDownDemoPage NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;

            return this;
        }

        public DropDownDemoPage SelectFromDropdownByText(string text)
        {
            _dropDown.SelectByText(text);

            return this;
        }
        public DropDownDemoPage SelectFromDropdownByValue(string text)
        {
            _dropDown.SelectByValue(text);

            return this;
        }
        public DropDownDemoPage ClickGetAllSelectedButton()
        {
            _getAllSelectedButton.Click();

            return this;
        }

        public DropDownDemoPage VerifyResult(string expectedResult)
        {
            Assert.AreEqual(ResultTextStatic + expectedResult, _resultText, "$Result is wrong, not{expectedResult}");

            return this;
        }
        public DropDownDemoPage ClickFirstSelectButton()
        {
            _firstSelectedButton.Click();
            return this;

        }
        public DropDownDemoPage ClickOnMultiDropDownElementByValue (string firstValue, string secondValue)
        {
            Actions action = new Actions(Driver);
            _multiDropdown.SelectByValue("Florida");
            action.KeyDown(Keys.Control);
            _multiDropdown.SelectByValue("Florida");
            action.KeyDown(Keys.Control);
            action.Build().Perform();
            return this;
        }
        public DropDownDemoPage VerifyMultipleSelectValueContains(string expectedValue)
        {
            Assert.IsTrue(_multiDropDownResult.Text.Contains(expectedValue), "Actual value is wrong.");

            return this;
        }
    }
}
