using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace YoutubeSignInAndVideoPlayback.pages.PageFacotryPattern
{
    class SignInPage
    {
        [FindsBy(How = How.CssSelector, Using = "div > input[type='email']")]
        private IWebElement emailInput;

        [FindsBy(How = How.CssSelector, Using = "div#identifierNext > content > span")]
        private IWebElement buttonNext;

        [FindsBy(How = How.CssSelector, Using = "div > input[type='password']")]
        private IWebElement passwordInput;

        [FindsBy(How = How.CssSelector, Using = "div#passwordNext > content > span")]
        private IWebElement buttonDone;

        private IWebDriver driver;

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        
        public HomePage SignIn(string username, string password)
        {
            emailInput.SendKeys(username);
            buttonNext.Click();
            passwordInput.SendKeys(password);
            buttonDone.Click();
            return new HomePage(driver);
        }


    }
}
