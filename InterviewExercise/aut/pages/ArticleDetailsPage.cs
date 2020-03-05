using InterviewExercise.aut.lib;
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
            Xunit.Assert.Equal(price, ArticlePrice.CreateWebElement().GetAttribute("text"));
        }

        public void AddProductToCart()
        {
            AddToCart.CreateWebElement().Click();
        }

        public void NavigateYourAmazon()
        {
            NavYourAmazon.CreateWebElement().Click();
        }
    }
}
