using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using YoutubeSignInAndVideoPlayback.WebDriver;

namespace YoutubeSignInAndVideoPlayback.Patterns.PageObjectPattern.Pages
{
    class FirstVideoPage : BasePage
    {
        private By ButtonAvatar = By.CssSelector("button#avatar-btn");
        private By ButtonSignOut = By.XPath("//a[@href='/logout']");        

        public IWebElement AvatarButton
        {
            get { return driver.FindElement(ButtonAvatar);  }
        }
        public IWebElement SignOutButton
        {
            get { return driver.FindElement(ButtonSignOut); }
        }

        public void ClickAvatarButton()
        {
            AvatarButton.Click();
        }

        public void ClickSignOutButton()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(ButtonSignOut));
            SignOutButton.Click();
        }
    }
}
