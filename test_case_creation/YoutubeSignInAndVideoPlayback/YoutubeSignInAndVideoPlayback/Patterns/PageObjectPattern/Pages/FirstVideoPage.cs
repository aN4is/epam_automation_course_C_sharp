using OpenQA.Selenium;
using YoutubeSignInAndVideoPlayback.WebDriver;

namespace YoutubeSignInAndVideoPlayback.pages.PageObjectPattern
{
    class FirstVideoPage : BasePage
    {
        private string ButtonAvatarCssLocator = "button#avatar-btn";
        private string ButtonSignOutXpathLocator = "//a[@href=\"/logout\"]";              

        //public FirstVideoPage(IWebDriver driver) : base(driver)
        //{
        //}

        public IWebElement AvatarButton
        {
            get { return Driver.GetDriver().FindElement(By.CssSelector(ButtonAvatarCssLocator));  }
        }
        public IWebElement SignOutButton
        {
            get { return Driver.GetDriver().FindElement(By.XPath(ButtonSignOutXpathLocator)); }
        }

        public void ClickAvatarButton()
        {
            AvatarButton.Click();
        }

        public void ClickSignOutButton()
        {
            SignOutButton.Click();
        }
    }
}
