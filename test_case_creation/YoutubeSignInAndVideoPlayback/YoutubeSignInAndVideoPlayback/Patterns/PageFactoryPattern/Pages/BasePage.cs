using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using YoutubeSignInAndVideoPlayback.WebDriver;

namespace YoutubeSignInAndVideoPlayback.Patterns.PageFactoryPattern.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver driver = Driver.GetDriver();
        private const int TimeoutSec = 5;
        protected WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(TimeoutSec));

        public BasePage(IWebDriver driver)
        {
            this.driver = Driver.GetDriver();
            PageFactory.InitElements(driver, this);
        }
    }
}
