using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewExercise.aut.lib
{
    public class WebObject
    {
        public IWebDriver _driver = DriverFactory.GetWebDriver();

        public string ELEMENT_LOCATOR;
        public string LOCATOR_USED;
        public string LOCATOR_METHOD;

        public WebObject(string locator)
        {
            ELEMENT_LOCATOR = locator;
        }

        public IWebElement CreateWebElement()
        {
            return _driver.FindElement(GetLocator());
        }

        public IReadOnlyCollection<IWebElement> CreateWebElementCollection()
        {
            return _driver.FindElements(GetLocator());
        }

        public SelectElement CreateSelectWebElement()
        {
            return new SelectElement(_driver.FindElement(GetLocator()));
        }

        private void LocatorParser()
        {
            int pos1, pos2, pos3;

            pos1 = ELEMENT_LOCATOR.IndexOf('(');
            pos2 = ELEMENT_LOCATOR.IndexOf(')');
            pos3 = ELEMENT_LOCATOR.IndexOf('.');

            LOCATOR_USED = ELEMENT_LOCATOR.Substring(pos1 + 2, ((pos2 - 1) - (pos1 + 2)));
            LOCATOR_METHOD = ELEMENT_LOCATOR.Substring(pos3 + 1, (pos1 - pos3) - 1);
        }

        private By GetLocator()
        {
            By actualSelector = null;

            LocatorParser();

            switch (LOCATOR_METHOD.ToLower())
            {
                case "xpath": actualSelector = By.XPath(LOCATOR_USED);
                    break;
                case "tagname":
                    actualSelector = By.TagName(LOCATOR_USED);
                    break;
                case "cssselector":
                    actualSelector = By.CssSelector(LOCATOR_USED);
                    break;
                case "id":
                    actualSelector = By.Id(LOCATOR_USED);
                    break;
                case "name":
                    actualSelector = By.Name(LOCATOR_USED);
                    break;
                case "classname":
                    actualSelector = By.ClassName(LOCATOR_USED);
                    break;
                case "linktext":
                    actualSelector = By.LinkText(LOCATOR_USED);
                    break;
                case "partiallinktext":
                    actualSelector = By.PartialLinkText(LOCATOR_USED);
                    break;

            }

            return actualSelector;
        }
    }
}
