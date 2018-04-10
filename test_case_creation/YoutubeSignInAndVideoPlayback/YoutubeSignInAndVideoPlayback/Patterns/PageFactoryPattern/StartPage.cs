using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace YoutubeSignInAndVideoPlayback.pages.PageFactoryPattern
{
    class StartPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='text']")]
        private IWebElement signInButton;

        public string BaseUrl = "https://youtube.com";

        private IWebDriver driver;


        public StartPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void OpenUrl()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

        public SignInPage OpenSignInPage()
        {
            signInButton.Click();
            return new SignInPage(driver);
        }

    }
}
