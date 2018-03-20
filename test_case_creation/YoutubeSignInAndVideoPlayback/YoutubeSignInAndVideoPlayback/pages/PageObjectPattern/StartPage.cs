using OpenQA.Selenium;


namespace YoutubeSignInAndVideoPlayback.pages.PageObjectPattern
{
    class StartPage
    {
        private string ButtonSignInXpathLocator = "//*[@id='text']";
        private string BaseUrl = "https://youtube.com";
        private IWebDriver driver;


        public StartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement SignInButton
        {
            get { return driver.FindElement(By.XPath(ButtonSignInXpathLocator));  }
        }

        public void OpenUrl()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

        public SignInPage OpenSignInPage()
        {
            SignInButton.Click();
            return new SignInPage(driver);
        }

    }
}
