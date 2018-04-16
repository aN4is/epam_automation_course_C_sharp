using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using YoutubeSignInAndVideoPlayback.WebDriver;

namespace YoutubeSignInAndVideoPlayback.pages.PageObjectPattern
{
    class SignInPage : BasePage
    {
        private By EmailInputField = By.CssSelector("div > input[type='email']");
        private By ButtonNext = By.CssSelector("div#identifierNext > content > span");
        private By PasswordInputField = By.CssSelector("div > input[type='password']");
        private By ButtonDone = By.CssSelector("div#passwordNext > content > span");      

        public IWebElement EmailInput
        {
            get { return driver.FindElement(EmailInputField);  } 
        }

        public IWebElement PasswordInput
        {
            get { return driver.FindElement(PasswordInputField); }
        }

        public IWebElement NextButton
        {
            get { return driver.FindElement(ButtonNext); }
        }

        public IWebElement DoneButton
        {
            get { return driver.FindElement(ButtonDone); }
        }

        public void EnterUsername(string username)
        {            
            wait.Until(ExpectedConditions.ElementIsVisible(EmailInputField));
            EmailInput.SendKeys(username);
        }
        public void ClickNextButton()
        {            
            wait.Until(ExpectedConditions.ElementIsVisible(ButtonNext));
            NextButton.Click();
        }

        public void EnterPassword(string password)
        {            
            wait.Until(ExpectedConditions.ElementIsVisible(PasswordInputField));
            PasswordInput.SendKeys(password);
        }
        public void ClickDoneButton()
        {            
            wait.Until(ExpectedConditions.ElementIsVisible(ButtonDone));
            DoneButton.Click();
        }
    }
}
