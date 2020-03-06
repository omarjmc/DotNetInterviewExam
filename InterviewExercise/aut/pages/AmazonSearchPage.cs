using InterviewExercise.aut.lib;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewExercise.aut.pages
{
    public class AmazonSearchPage
    {
        WebObject SearchBar = new WebObject(JSonReader.GetProperty("objects/AmazonSearch.json", "SearchBar"));
        WebObject SearchButton = new WebObject(JSonReader.GetProperty("objects/AmazonSearch.json", "SearchButton"));
        WebObject SearchResult = new WebObject(JSonReader.GetProperty("objects/AmazonSearch.json", "SearchResult"));
        WebObject ResultPrice = new WebObject(JSonReader.GetProperty("objects/AmazonSearch.json", "ResultPrice"));

        public void searchItem(String item)
        {
            new WebDriverWait(DriverFactory.GetWebDriver(), TimeSpan.FromSeconds(20)).Until(drv => drv.FindElement(SearchBar.GetActualLocator()).Displayed);
            SearchBar.CreateWebElement().SendKeys(item);
        }

        public void clickSearch()
        {
            new WebDriverWait(DriverFactory.GetWebDriver(), TimeSpan.FromSeconds(20)).Until(drv => drv.FindElement(SearchButton.GetActualLocator()).Displayed);
            SearchButton.CreateWebElement().Click();
        }

        public void SelectSearchResult()
        {
            new WebDriverWait(DriverFactory.GetWebDriver(), TimeSpan.FromSeconds(20)).Until(drv => drv.FindElement(SearchResult.GetActualLocator()).Displayed);
            SearchResult.CreateWebElement().Click();
        }

        public string GetArticlePrice()
        {
            return ResultPrice.CreateWebElement().GetAttribute("text");
        }
    }
}
