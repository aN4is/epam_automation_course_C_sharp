using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using YoutubeSignInAndVideoPlayback.WebDriver;

namespace YoutubeSignInAndVideoPlayback.pages.PageObjectPattern
{
    class SignInPage : BasePage
    {
        private string EmailInputCssLocator = "div > input[type='email']";
        private string ButtonNextCssLocator = "div#identifierNext > content > span";
        private string PasswordInputCssLocator = "div > input[type='password']";
        private string ButtonDoneCssLocator = "div#passwordNext > content > span";

        //public SignInPage(IWebDriver driver) : base(driver)
        //{            
        //}

        public IWebElement EmailInput
        {
            get { return Driver.GetDriver().FindElement(By.CssSelector(EmailInputCssLocator));  } 
        }

        public IWebElement PasswordInput
        {
            get { return Driver.GetDriver().FindElement(By.CssSelector(PasswordInputCssLocator)); }
        }

        public IWebElement NextButton
        {
            get { return Driver.GetDriver().FindElement(By.CssSelector(ButtonNextCssLocator)); }
        }

        public IWebElement DoneButton
        {
            get { return Driver.GetDriver().FindElement(By.CssSelector(ButtonDoneCssLocator)); }
        }

        public void EnterUsername(string username)
        {            
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(EmailInputCssLocator)));
            EmailInput.SendKeys(username);
        }
        public void ClickNextButton()
        {            
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(ButtonNextCssLocator)));
            NextButton.Click();
        }

        public void EnterPassword(string password)
        {            
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(PasswordInputCssLocator)));
            PasswordInput.SendKeys(password);
        }
        public void ClickDoneButton()
        {            
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(ButtonDoneCssLocator)));
            DoneButton.Click();
        }
    }
}
