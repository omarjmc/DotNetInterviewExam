using InterviewExercise.aut.facades;
using InterviewExercise.aut.lib;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace InterviewExercise.specflow.stepdef
{
    [Binding]
    public class StepDeffinitions : BaseTest
    {
        AmazonSearchFcde amazonFcde = new AmazonSearchFcde();

        [Given(@"User navigates to Amazon page")]
        public void userNav()
        {
            StartBrowser("https://www.amazon.com/ref=nav_logo");
        }

        [When(@"The user performs a search for (.*)")]
        public void searchItem(string item)
        {
            amazonFcde.SearchAndSelectItem(item);
        }

        [Then(@"The user Validates the price and adds product to cart")]
        public void validatePriceAddToCart()
        {
            amazonFcde.ValidatePriceAndAddToCart();
        }

        [Then(@"The user Creates an Account")]
        public void createAmazonAccount()
        {
            amazonFcde.CreateAmazonAccount();
        }

        [Then(@"Close browser")]
        public void closeBrowser()
        {
            CloseBrowser();
        }
    }
}
