using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace YoutubeSignInAndVideoPlayback.Patterns.PageFactoryPattern.Pages
{
    class FirstVideoPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "button#avatar-btn")]
        private IWebElement AvatarButton;

        [FindsBy(How = How.XPath, Using = "//a[@href=\"/logout\"]")]
        private IWebElement SignOutButton;               

        public FirstVideoPage(IWebDriver driver) : base(driver)    {   }

        public void ClickAvatarButton()
        {
            AvatarButton.Click();
        }

        public void ClickSignOutButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(SignOutButton));
            SignOutButton.Click();
        }
    }
}
