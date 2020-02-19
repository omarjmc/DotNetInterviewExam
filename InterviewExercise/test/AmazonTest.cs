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
            BaseTest.StartBrowser("https://www.amazon.com/ref=nav_logo");
        }

        [Fact]
        public void SearchAmazon()
        {
            amazonFcde.SearchItem("HP printers");
        }

        public void Dispose()
        {
            BaseTest.CloseBrowser();
        }
    }
}
