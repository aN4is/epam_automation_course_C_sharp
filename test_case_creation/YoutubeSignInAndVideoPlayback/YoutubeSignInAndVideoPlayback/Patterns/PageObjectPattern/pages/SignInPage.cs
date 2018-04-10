using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace YoutubeSignInAndVideoPlayback.pages.PageObjectPattern
{
    class SignInPage : BasePage
    {
        private string EmailInputCssLocator = "div > input[type='email']";
        private string ButtonNextCssLocator = "div#identifierNext > content > span";
        private string PasswordInputCssLocator = "div > input[type='password']";
        private string ButtonDoneCssLocator = "div#passwordNext > content > span";

        WebDriverWait wait;



        public SignInPage(IWebDriver driver) : base(driver)
        {            
        }

        public IWebElement EmailInput
        {
            get { return Driver.FindElement(By.CssSelector(EmailInputCssLocator));  } 
        }

        public IWebElement PasswordInput
        {
            get { return Driver.FindElement(By.CssSelector(PasswordInputCssLocator)); }
        }

        public IWebElement NextButton
        {
            get { return Driver.FindElement(By.CssSelector(ButtonNextCssLocator)); }
        }

        public IWebElement DoneButton
        {
            get { return Driver.FindElement(By.CssSelector(ButtonDoneCssLocator)); }
        }

        public void EnterUsername(string username)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div > input[type='email']")));
            EmailInput.SendKeys(username);
        }
        public void ClickNextButton()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div#identifierNext > content > span")));
            NextButton.Click();
        }

        public void EnterPassword(string password)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div > input[type='password']")));
            PasswordInput.SendKeys(password);
        }
        public void ClickDoneButton()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div#passwordNext > content > span")));
            DoneButton.Click();
        }
    }
}
