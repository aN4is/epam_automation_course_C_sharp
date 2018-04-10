using OpenQA.Selenium;
using System.Threading;

namespace YoutubeSignInAndVideoPlayback.pages.PageObjectPattern
{
    class HomePage
    {
        private string SearchFieldCssLocator = "#search";
        private string RequiredVideoXpathLocator = ".//ytd-video-renderer[1]";

        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement SearchField
        {
            get { return driver.FindElement(By.CssSelector(SearchFieldCssLocator));  }
        }

        public IWebElement FirstVideoInGrid
        {
            get { return driver.FindElement(By.XPath(RequiredVideoXpathLocator)); }
        }

        public FirstVideoPage SelectVideo(string search_string)
        {            
            SearchField.SendKeys(search_string);
            SearchField.SendKeys(Keys.Enter);                        
            FirstVideoInGrid.Click();
            return new FirstVideoPage(driver);            
        }


    }
}
