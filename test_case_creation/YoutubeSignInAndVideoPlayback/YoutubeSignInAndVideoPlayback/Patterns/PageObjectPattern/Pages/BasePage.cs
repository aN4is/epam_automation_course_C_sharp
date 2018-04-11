using OpenQA.Selenium.Support.UI;
using System;
using YoutubeSignInAndVideoPlayback.WebDriver;

namespace YoutubeSignInAndVideoPlayback.pages.PageObjectPattern
{
    public abstract class BasePage
    {
        //public IWebDriver Driver { get; private set; }

        //public BasePage(IWebDriver _driver)
        //{
        //    Driver = _driver;
        //}

        private const int TimeoutSec = 5;
        public WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(TimeoutSec));
    }
}
