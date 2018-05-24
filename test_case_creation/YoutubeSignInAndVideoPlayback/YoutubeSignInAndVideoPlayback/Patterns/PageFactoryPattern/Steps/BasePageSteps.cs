using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using YoutubeSignInAndVideoPlayback.WebDriver;

namespace YoutubeSignInAndVideoPlayback.Patterns.PageFactoryPattern.Steps
{
    public abstract class BasePageSteps
    {
        private const int TimeoutSec = 5;      
        protected static IWebDriver driver = Driver.GetDriver();

        protected WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(TimeoutSec));

        public string GetPageTitle(string ExpectedPageTitle)
        {        
            wait.Until(ExpectedConditions.TitleContains(ExpectedPageTitle));
            return driver.Title;
        }
    }
}
