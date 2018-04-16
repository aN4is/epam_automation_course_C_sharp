using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using YoutubeSignInAndVideoPlayback.WebDriver;

namespace YoutubeSignInAndVideoPlayback.Patterns.PageFactoryPattern.Pages
{
    class StartPage : BasePage
    {
        public const string BaseUrl = "https://youtube.com";

        [FindsBy(How = How.XPath, Using = "//*[@id='text']")]
        private IWebElement SignInButton;        

        public StartPage(IWebDriver driver): base(driver)   {   }

        public void OpenUrl()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

        public void ClickSignInButton()
        {
            SignInButton.Click();
        }

    }
}
