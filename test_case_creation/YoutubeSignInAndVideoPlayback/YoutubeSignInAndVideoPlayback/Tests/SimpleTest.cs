using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace YoutubeSignInAndVideoPlayback

{
    public class SimpleTest
    {

        IWebDriver driver;
        WebDriverWait wait;

        [SetUp]
        public void Initialize()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [TearDown]
        public void EndTest()
        {
            driver.Quit();
        }

        [Test]
        public void YoutubeSignInAndVideoPlaybackTest()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            driver.Navigate().GoToUrl("https://youtube.com");
            IWebElement signInButton = driver.FindElement(By.Id("text"));
            signInButton.Click();

            //IWebElement useAnotherAccount = driver.FindElement(By.CssSelector("div + p[text='Use another account']"));
            //useAnotherAccount.Click();

            IWebElement enterEmailField = driver.FindElement(By.CssSelector("div > input[type='email']"));
            enterEmailField.SendKeys("mattaku.ad@gmail.com");

            IWebElement nextButton = driver.FindElement(By.CssSelector("div#identifierNext > content > span"));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div#identifierNext > content > span")));
            nextButton.Click();

            IWebElement enterPasswordField = driver.FindElement(By.CssSelector("div > input[type='password']"));
            enterPasswordField.SendKeys("Q!w2e3r4");

            IWebElement doneButton = driver.FindElement(By.CssSelector("div#passwordNext > content > span"));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div#passwordNext > content > span")));
            doneButton.Click();

            IWebElement searchField = driver.FindElement(By.CssSelector("#search"));
            searchField.SendKeys("gnossienne 1 piano");
            searchField.SendKeys(Keys.Enter);

            IWebElement firstVideoInGrid = driver.FindElement(By.XPath(".//a[@title='ERIK SATIE Gnossienne 1 - Alessio Nanni, piano']"));
            firstVideoInGrid.Click();

            wait.Until(ExpectedConditions.TitleContains("ERIK SATIE Gnossienne 1 - Alessio Nanni, piano"));
            var pageTitle = driver.Title;            
            
            StringAssert.Contains("ERIK SATIE Gnossienne 1 - Alessio Nanni, piano", pageTitle);

            IWebElement avatarButton = driver.FindElement(By.CssSelector("button#avatar-btn"));
            avatarButton.Click();

            IWebElement signOutButton = driver.FindElement(By.XPath("//a[@href=\"/logout\"]"));
            signOutButton.Click();

        }


        
    }
}
