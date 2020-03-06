using InterviewExercise.aut.facades;
using InterviewExercise.aut.lib;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace InterviewExercise.test
{
    public class AmazonTest : IDisposable
    {
        AmazonSearchFcde amazonFcde = new AmazonSearchFcde();

        public AmazonTest()
        {
            BaseTest.StartBrowser("https://www.amazon.com");
        }

        [Fact]
        public void SearchAmazon()
        {
            /*
             * Perform an Amazon Search and select first product. Get the price of the product 
             * selected
             */
            amazonFcde.SearchAndSelectItem("Samsung Galaxy S9");

            /*
             * Assert the price of the product is the same in the searcch page and in the 
             * product details page.
             * Add the product to the cart
             */
            amazonFcde.ValidatePriceAndAddToCart();

            /*
             * Create the Amazon account by providing details:
             * -Name
             * -Email
             * -Password
             * -Password  check
             * 
             * Assert the existance of the banner Amazon
             */
            amazonFcde.CreateAmazonAccount();
        }

        public void Dispose()
        {
            BaseTest.CloseBrowser();
        }
    }
}
