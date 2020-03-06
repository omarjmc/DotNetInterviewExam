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

        private string ELEMENT_LOCATOR;
        private string LOCATOR_USED;
        private string LOCATOR_METHOD;
        private By ACTUAL_SELECTOR;

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
            ACTUAL_SELECTOR = null;

            LocatorParser();

            switch (LOCATOR_METHOD.ToLower())
            {
                case "xpath": ACTUAL_SELECTOR = By.XPath(LOCATOR_USED);
                    break;
                case "tagname":
                    ACTUAL_SELECTOR = By.TagName(LOCATOR_USED);
                    break;
                case "cssselector":
                    ACTUAL_SELECTOR = By.CssSelector(LOCATOR_USED);
                    break;
                case "id":
                    ACTUAL_SELECTOR = By.Id(LOCATOR_USED);
                    break;
                case "name":
                    ACTUAL_SELECTOR = By.Name(LOCATOR_USED);
                    break;
                case "classname":
                    ACTUAL_SELECTOR = By.ClassName(LOCATOR_USED);
                    break;
                case "linktext":
                    ACTUAL_SELECTOR = By.LinkText(LOCATOR_USED);
                    break;
                case "partiallinktext":
                    ACTUAL_SELECTOR = By.PartialLinkText(LOCATOR_USED);
                    break;

            }

            return ACTUAL_SELECTOR;
        }

        public By GetActualLocator()
        {
            GetLocator();
            return ACTUAL_SELECTOR;
        }
    }
}
