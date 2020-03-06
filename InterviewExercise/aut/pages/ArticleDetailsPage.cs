using InterviewExercise.aut.lib;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewExercise.aut.pages
{
    public class ArticleDetailsPage
    {
        WebObject ArticlePrice = new WebObject(JSonReader.GetProperty("objects/ArticleDetails.json", "ArticlePrice"));
        WebObject AddToCart = new WebObject(JSonReader.GetProperty("objects/ArticleDetails.json", "AddToCart"));
        WebObject NavYourAmazon = new WebObject(JSonReader.GetProperty("objects/ArticleDetails.json", "NavYourAmazon"));

        public void AssertPrice(string price)
        {
            new WebDriverWait(DriverFactory.GetWebDriver(), TimeSpan.FromSeconds(20)).Until(drv => drv.FindElement(ArticlePrice.GetActualLocator()).Displayed);
            Xunit.Assert.Equal(price, ArticlePrice.CreateWebElement().GetAttribute("text"));
        }

        public void AddProductToCart()
        {
            new WebDriverWait(DriverFactory.GetWebDriver(), TimeSpan.FromSeconds(20)).Until(drv => drv.FindElement(AddToCart.GetActualLocator()).Displayed);
            AddToCart.CreateWebElement().Click();
        }

        public void NavigateYourAmazon()
        {
            new WebDriverWait(DriverFactory.GetWebDriver(), TimeSpan.FromSeconds(20)).Until(drv => drv.FindElement(NavYourAmazon.GetActualLocator()).Displayed);
            NavYourAmazon.CreateWebElement().Click();
        }
    }
}
