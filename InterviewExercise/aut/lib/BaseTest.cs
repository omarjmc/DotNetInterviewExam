using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewExercise.aut.lib
{
    public class BaseTest
    {
        public static IWebDriver _driver;

        public static void StartBrowser(string URL)
        {
            _driver = DriverFactory.GetWebDriver();
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(Convert.ToDouble(JSonReader.GetProperty("execution/ExecutionParaMeters.json", "PageLoad")));
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Convert.ToDouble(JSonReader.GetProperty("execution/ExecutionParaMeters.json", "ImplicitWat")));
            _driver.Navigate().GoToUrl(URL);
        }

        public static void CloseBrowser()
        {
            _driver.Quit();
            _driver = null;
        }
    }
}
