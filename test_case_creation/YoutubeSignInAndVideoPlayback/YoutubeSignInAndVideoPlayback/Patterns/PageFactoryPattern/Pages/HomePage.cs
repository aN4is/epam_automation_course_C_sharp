using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace YoutubeSignInAndVideoPlayback.Patterns.PageFactoryPattern.Pages
{
    class HomePage : BasePage
    {

        [FindsBy(How = How.CssSelector, Using = "#search")]
        private IWebElement SearchField;

        [FindsBy(How = How.XPath, Using = ".//ytd-video-renderer[1]")]
        private IWebElement FirstVideoInGrid;        

        public HomePage(IWebDriver driver) : base(driver)  {   }


        public void SearchForRequiredVideo(string search_string)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(SearchField));
            SearchField.SendKeys(search_string);
            SearchField.SendKeys(Keys.Enter);
        }

        public void ClickFirstVideoInGrid()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(FirstVideoInGrid));
            FirstVideoInGrid.Click();
        }

    }
}
