using OpenQA.Selenium;


namespace YoutubeSignInAndVideoPlayback.pages.PageObjectPattern
{
    class FirstVideoPage
    {
        private string ButtonAvatarCssLocator = "button#avatar-btn";
        private string ButtonSignOutXpathLocator = "//a[@href=\"/logout\"]";
        private string ExpectedPageTitle = "ERIK SATIE Gnossienne 1 - Alessio Nanni, piano";

        public IWebDriver driver;

        public FirstVideoPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }

        public IWebElement AvatarButton
        {
            get { return driver.FindElement(By.CssSelector(ButtonAvatarCssLocator));  }
        }
        public IWebElement SignOutButton
        {
            get { return driver.FindElement(By.XPath(ButtonSignOutXpathLocator)); }
        }

        public void SignOut()
        {
            AvatarButton.Click();
            SignOutButton.Click();
        }
    }
}
