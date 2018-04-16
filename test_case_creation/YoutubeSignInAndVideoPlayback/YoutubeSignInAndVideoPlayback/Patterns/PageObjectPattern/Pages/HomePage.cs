using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using YoutubeSignInAndVideoPlayback.WebDriver;

namespace YoutubeSignInAndVideoPlayback.pages.PageObjectPattern
{
    class HomePage : BasePage
    {
        private By FieldSearch = By.CssSelector("#search");
        private By VideoRequired = By.XPath(".//ytd-video-renderer[1]");

        public IWebElement SearchField
        {
            get { return driver.FindElement(FieldSearch);  }
        }

        public IWebElement FirstVideoInGrid
        {
            get { return driver.FindElement(VideoRequired); }
        }

        public void SearchForRequiredVideo(string search_string)
        {           
            wait.Until(ExpectedConditions.ElementIsVisible(FieldSearch));
            SearchField.SendKeys(search_string);
            SearchField.SendKeys(Keys.Enter);
        }

        public void ClickFirstVideoInGrid()
        {            
            wait.Until(ExpectedConditions.ElementIsVisible(VideoRequired));
            FirstVideoInGrid.Click();
        }
    }
}
