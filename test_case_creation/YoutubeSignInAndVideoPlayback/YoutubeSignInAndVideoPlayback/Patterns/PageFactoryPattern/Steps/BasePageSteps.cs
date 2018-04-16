using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using YoutubeSignInAndVideoPlayback.WebDriver;

namespace YoutubeSignInAndVideoPlayback.pages.PageFactoryPattern.steps
{
    public abstract class BasePageSteps
    {
        private const int TimeoutSec = 5;      
        public static IWebDriver driver = Driver.GetDriver();

        WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(TimeoutSec));

        public string GetPageTitle(string ExpectedPageTitle)
        {        
            wait.Until(ExpectedConditions.TitleContains(ExpectedPageTitle));
            return driver.Title;
        }
    }
}
