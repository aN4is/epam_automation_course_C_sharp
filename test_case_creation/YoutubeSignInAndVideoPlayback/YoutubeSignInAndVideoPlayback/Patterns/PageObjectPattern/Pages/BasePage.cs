using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using YoutubeSignInAndVideoPlayback.WebDriver;

namespace YoutubeSignInAndVideoPlayback.Patterns.PageObjectPattern.Pages
{
    public abstract class BasePage
    {
        private const int TimeoutSec = 5;
        public WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(TimeoutSec));
        protected IWebDriver driver = Driver.GetDriver();
    }
}
