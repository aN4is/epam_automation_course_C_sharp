using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using YoutubeSignInAndVideoPlayback.WebDriver;

namespace YoutubeSignInAndVideoPlayback.Patterns.PageObjectPattern.Steps
{
    public abstract class BasePageSteps
    {
        private const int TimeoutSec = 5;      
        protected IWebDriver driver = Driver.GetDriver();

        WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(TimeoutSec));

        public string GetPageTitle(string ExpectedPageTitle)
        {        
            wait.Until(ExpectedConditions.TitleContains(ExpectedPageTitle));
            return driver.Title;
        }
    }
}
