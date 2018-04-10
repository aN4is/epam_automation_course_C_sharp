using OpenQA.Selenium;


namespace YoutubeSignInAndVideoPlayback.pages.PageObjectPattern
{
    class StartPage : BasePage
    {
        private string ButtonSignInXpathLocator = "//*[@id='text']";
        private string BaseUrl = "https://youtube.com";
        private By ButtonSignInXpathLocator1 = By.XPath("//*[@id='text']");
        
        
        public StartPage(IWebDriver driver) : base(driver)
        {            
        }

        public IWebElement SignInButton
        {
            get { return Driver.FindElement(By.XPath(ButtonSignInXpathLocator));  }
        }

        public void OpenUrl()
        {
            Driver.Navigate().GoToUrl(BaseUrl);
        }

        public void ClickSignInButton()
        {
            SignInButton.Click();
        }


    }
}
