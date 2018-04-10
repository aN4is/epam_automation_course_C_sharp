using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace YoutubeSignInAndVideoPlayback.pages.PageObjectPattern
{
    class HomePage : BasePage
    {
        private string SearchFieldCssLocator = "#search";
        private string RequiredVideoXpathLocator = ".//ytd-video-renderer[1]";

        
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement SearchField
        {
            get { return Driver.FindElement(By.CssSelector(SearchFieldCssLocator));  }
        }

        public IWebElement FirstVideoInGrid
        {
            get { return Driver.FindElement(By.XPath(RequiredVideoXpathLocator)); }
        }

        public void SearchForRequiredVideo(string search_string)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#search")));
            SearchField.SendKeys(search_string);
            SearchField.SendKeys(Keys.Enter);
        }

        public void ClickFirstVideoInGrid()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//ytd-video-renderer[1]")));
            FirstVideoInGrid.Click();
        }
    }
}
