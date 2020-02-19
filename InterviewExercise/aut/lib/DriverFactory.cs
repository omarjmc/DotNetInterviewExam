using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewExercise.aut.lib
{
    public class DriverFactory
    {
        public static IWebDriver _webDriver = null;

        public static void InitDriver()
        {
            if(_webDriver == null)
            {
                _webDriver = new ChromeDriver(chromeDriverDirectory:@Environment.CurrentDirectory);
            }
        }

        public static IWebDriver GetWebDriver()
        {
            if(_webDriver == null)
            {
                InitDriver();
            }

            return _webDriver;
        }
    }
}
