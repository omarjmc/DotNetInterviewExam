
using InterviewExercise.aut.lib;
using InterviewExercise.aut.pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewExercise.aut.facades
{
    public class AmazonSearchFcde
    {
        //Pages
        AmazonSearchPage searchPage = new AmazonSearchPage();
        ArticleDetailsPage articleDetails = new ArticleDetailsPage();
        AmazonSignInPage amazonSign = new AmazonSignInPage();
        AccountCreationPage accountCreation = new AccountCreationPage();

        //Variables
        string ArticlePrice;

        public void SearchAndSelectItem(string item)
        {
            searchPage.searchItem(item);
            searchPage.clickSearch();
            ArticlePrice = searchPage.GetArticlePrice();
            searchPage.SelectSearchResult();
        }

        public void ValidatePriceAndAddToCart()
        {
            articleDetails.AssertPrice(ArticlePrice);
            articleDetails.AddProductToCart();
        }

        public void CreateAmazonAccount()
        {
            articleDetails.NavigateYourAmazon();
            amazonSign.ClickCreateYourAmazon();
            accountCreation.EnterName(JSonReader.GetProperty("execution/ExecutionData.json","Name"));
            accountCreation.EnterEmail(JSonReader.GetProperty("execution/ExecutionData.json", "Email"));
            accountCreation.EnterPassword(JSonReader.GetProperty("execution/ExecutionData.json", "Password"));
            accountCreation.EnterPassCheck(JSonReader.GetProperty("execution/ExecutionData.json", "PassCheck"));
        }
    }
}
