using InterviewExercise.aut.lib;
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
            SearchBar.CreateWebElement().SendKeys(item);
        }

        public void clickSearch()
        {
            SearchButton.CreateWebElement().Click();
        }

        public void SelectSearchResult()
        {
            SearchResult.CreateWebElement().Click();
        }

        public string GetArticlePrice()
        {
            return ResultPrice.CreateWebElement().GetAttribute("text");
        }
    }
}
