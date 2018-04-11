using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using YoutubeSignInAndVideoPlayback.WebDriver;

namespace YoutubeSignInAndVideoPlayback.pages.PageObjectPattern
{
    class HomePage : BasePage
    {
        private string SearchFieldCssLocator = "#search";
        private string RequiredVideoXpathLocator = ".//ytd-video-renderer[1]";
       
        //public HomePage(IWebDriver driver) : base(driver)
        //{
        //}       

        public IWebElement SearchField
        {
            get { return Driver.GetDriver().FindElement(By.CssSelector(SearchFieldCssLocator));  }
        }

        public IWebElement FirstVideoInGrid
        {
            get { return Driver.GetDriver().FindElement(By.XPath(RequiredVideoXpathLocator)); }
        }

        public void SearchForRequiredVideo(string search_string)
        {           
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(SearchFieldCssLocator)));
            SearchField.SendKeys(search_string);
            SearchField.SendKeys(Keys.Enter);
        }

        public void ClickFirstVideoInGrid()
        {            
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(RequiredVideoXpathLocator)));
            FirstVideoInGrid.Click();
        }
    }
}
