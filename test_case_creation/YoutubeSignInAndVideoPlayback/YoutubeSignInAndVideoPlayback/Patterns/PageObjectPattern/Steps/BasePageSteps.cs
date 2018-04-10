using OpenQA.Selenium.Support.UI;
using System;
using YoutubeSignInAndVideoPlayback.WebDriver;

namespace YoutubeSignInAndVideoPlayback.pages.PageObjectPattern.steps
{
    public abstract class BasePageSteps
    {
        private const int TimeoutSec = 5;               
        public string ExpectedPageTitle;

        WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(TimeoutSec));

        public string GetPageTitle(string ExpectedPageTitle)
        {        
            wait.Until(ExpectedConditions.TitleContains(ExpectedPageTitle));
            return Driver.GetDriver().Title;
        }
    }
}
