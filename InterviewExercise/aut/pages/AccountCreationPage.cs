using InterviewExercise.aut.lib;
using OpenQA.Selenium.Support.UI;
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
            new WebDriverWait(DriverFactory.GetWebDriver(), TimeSpan.FromSeconds(20)).Until(drv => drv.FindElement(Name.GetActualLocator()).Displayed);
            Name.CreateWebElement().SendKeys(name);
        }

        public void EnterEmail(string email)
        {
            new WebDriverWait(DriverFactory.GetWebDriver(), TimeSpan.FromSeconds(20)).Until(drv => drv.FindElement(Email.GetActualLocator()).Displayed);
            Email.CreateWebElement().SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            new WebDriverWait(DriverFactory.GetWebDriver(), TimeSpan.FromSeconds(20)).Until(drv => drv.FindElement(Password.GetActualLocator()).Displayed);
            Password.CreateWebElement().SendKeys(password);
        }

        public void EnterPassCheck(string password)
        {
            new WebDriverWait(DriverFactory.GetWebDriver(), TimeSpan.FromSeconds(20)).Until(drv => drv.FindElement(ReenterPass.GetActualLocator()).Displayed);
            ReenterPass.CreateWebElement().SendKeys(password);
        }

        public void AssertBanner()
        {
            new WebDriverWait(DriverFactory.GetWebDriver(), TimeSpan.FromSeconds(20)).Until(drv => drv.FindElement(Banner.GetActualLocator()).Displayed);
            Xunit.Assert.True(Banner.CreateWebElement().Displayed);
        }
    }
}
