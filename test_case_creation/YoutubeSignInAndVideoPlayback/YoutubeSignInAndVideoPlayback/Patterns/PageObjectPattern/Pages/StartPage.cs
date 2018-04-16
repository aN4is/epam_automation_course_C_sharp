using OpenQA.Selenium;
using YoutubeSignInAndVideoPlayback.WebDriver;

namespace YoutubeSignInAndVideoPlayback.pages.PageObjectPattern
{
    class StartPage : BasePage
    {
        private const string BaseUrl = "https://youtube.com";
        private By ButtonSignIn = By.XPath("//*[@id='text']");        


        public IWebElement SignInButton
        {
            get { return driver.FindElement(ButtonSignIn);  }
        }

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
