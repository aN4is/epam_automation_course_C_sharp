using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace YoutubeSignInAndVideoPlayback.Patterns.PageFactoryPattern.Pages
{
    class SignInPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "div > input[type='email']")]
        private IWebElement EmailInputField;

        [FindsBy(How = How.CssSelector, Using = "div#identifierNext > content > span")]
        private IWebElement NextButton;

        [FindsBy(How = How.CssSelector, Using = "div > input[type='password']")]
        private IWebElement PasswordInputField;

        [FindsBy(How = How.CssSelector, Using = "div#passwordNext > content > span")]
        private IWebElement DoneButton;
                

        public SignInPage(IWebDriver driver) : base(driver) {   }


        public void EnterUsername(string username)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(EmailInputField));
            EmailInputField.SendKeys(username);
        }
        public void ClickNextButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(NextButton));
            NextButton.Click();
        }

        public void EnterPassword(string password)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(PasswordInputField));
            PasswordInputField.SendKeys(password);
        }
        public void ClickDoneButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(DoneButton));
            DoneButton.Click();
        }


    }
}
