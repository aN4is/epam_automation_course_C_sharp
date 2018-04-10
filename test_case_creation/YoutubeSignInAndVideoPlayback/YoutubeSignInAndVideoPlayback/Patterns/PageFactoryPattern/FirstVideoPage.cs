using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace YoutubeSignInAndVideoPlayback.pages.PageFactoryPattern
{
    class FirstVideoPage
    {
        [FindsBy(How = How.CssSelector, Using = "button#avatar-btn")]
        private IWebElement avatarButton;

        [FindsBy(How = How.XPath, Using = "//a[@href=\"/logout\"]")]
        private IWebElement signOutButton;


        private string ExpectedPageTitle = "ERIK SATIE Gnossienne 1 - Alessio Nanni, piano";

        public IWebDriver driver;

        public FirstVideoPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }

        public void SignOut()
        {
            avatarButton.Click();
            signOutButton.Click();
        }
    }
}
