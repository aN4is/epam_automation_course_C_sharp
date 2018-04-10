using OpenQA.Selenium;
using YoutubeSignInAndVideoPlayback.WebDriver;

namespace YoutubeSignInAndVideoPlayback.pages.PageObjectPattern
{
    class StartPage : BasePage
    {
        private string ButtonSignInXpathLocator = "//*[@id='text']";
        private string BaseUrl = "https://youtube.com";
        private By ButtonSignInXpathLocator1 = By.XPath("//*[@id='text']");
        
        
        //public StartPage(IWebDriver driver) : base(driver)
        //{            
        //}

        public IWebElement SignInButton
        {
            get { return Driver.GetDriver().FindElement(By.XPath(ButtonSignInXpathLocator));  }
        }

        public void OpenUrl()
        {
            Driver.GetDriver().Navigate().GoToUrl(BaseUrl);
        }

        public void ClickSignInButton()
        {
            SignInButton.Click();
        }


    }
}
