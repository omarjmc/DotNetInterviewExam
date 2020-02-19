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
            amazonFcde.SearchItem(item);
        }

        [Then(@"Close browser")]
        public void closeBrowser()
        {
            CloseBrowser();
        }
    }
}
