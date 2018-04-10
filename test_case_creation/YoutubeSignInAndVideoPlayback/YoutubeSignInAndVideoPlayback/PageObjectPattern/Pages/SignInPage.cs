using OpenQA.Selenium;


namespace YoutubeSignInAndVideoPlayback.pages.PageObjectPattern
{
    class SignInPage
    {
        private string EmailInputCssLocator = "div > input[type='email']";
        private string ButtonNextCssLocator = "div#identifierNext > content > span";
        private string PasswordInputCssLocator = "div > input[type='password']";
        private string ButtonDoneCssLocator = "div#passwordNext > content > span";

        private IWebDriver driver;

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement EmailInput
        {
            get { return driver.FindElement(By.CssSelector(EmailInputCssLocator));  } 
        }

        public IWebElement PasswordInput
        {
            get { return driver.FindElement(By.CssSelector(PasswordInputCssLocator)); }
        }

        public IWebElement NextButton
        {
            get { return driver.FindElement(By.CssSelector(ButtonNextCssLocator)); }
        }

        public IWebElement DoneButton
        {
            get { return driver.FindElement(By.CssSelector(ButtonDoneCssLocator)); }
        }

        public HomePage SignIn(string username, string password)
        {            
            EmailInput.SendKeys(username);           
            NextButton.Click();            
            PasswordInput.SendKeys(password);            
            DoneButton.Click();
            return new HomePage(driver);
        }


    }
}
