using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace YoutubeSignInAndVideoPlayback.pages.PageFactoryPattern
{
    class HomePage
    {

        [FindsBy(How = How.CssSelector, Using = "#search")]
        private IWebElement searchField;

        [FindsBy(How = How.XPath, Using = ".//ytd-video-renderer[1]")]
        private IWebElement firstVideo;


        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        public FirstVideoPage SelectVideo(string search_string)
        {
            searchField.SendKeys(search_string);
            searchField.SendKeys(Keys.Enter);
            firstVideo.Click();
            return new FirstVideoPage(driver);
        }


    }
}
