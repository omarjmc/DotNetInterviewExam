using InterviewExercise.aut.lib;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewExercise.aut.pages
{
    public class AccountCreationPage
    {
        WebObject Name = new WebObject(JSonReader.GetProperty("objects/AccountCreation.json", "Name"));
        WebObject Email = new WebObject(JSonReader.GetProperty("objects/AccountCreation.json", "Email"));
        WebObject Password = new WebObject(JSonReader.GetProperty("objects/AccountCreation.json", "Password"));
        WebObject ReenterPass = new WebObject(JSonReader.GetProperty("objects/AccountCreation.json", "ReenterPass"));
        WebObject Banner = new WebObject(JSonReader.GetProperty("objects/AccountCreation.json", "Banner"));

        public void EnterName(string name)
        {
            Name.CreateWebElement().SendKeys(name);
        }

        public void EnterEmail(string email)
        {
            Email.CreateWebElement().SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            Password.CreateWebElement().SendKeys(password);
        }

        public void EnterPassCheck(string password)
        {
            ReenterPass.CreateWebElement().SendKeys(password);
        }

        public void AssertBanner()
        {
            Xunit.Assert.True(Banner.CreateWebElement().Displayed);
        }
    }
}
