using InterviewExercise.aut.lib;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewExercise.aut.pages
{
    public class AmazonSignInPage
    {
        WebObject CreateAccount = new WebObject(JSonReader.GetProperty("objects/AmazonSignIn.json", "CreateAccount"));

        public void ClickCreateYourAmazon()
        {
            CreateAccount.CreateWebElement().Click();
        }
    }
}
