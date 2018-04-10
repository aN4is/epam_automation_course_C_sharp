using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace YoutubeSignInAndVideoPlayback.WebDriver
{
    public static class Driver
    {
        private static IWebDriver instance;       

        public static IWebDriver GetDriver()
        {                   
            if (instance == null)
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                instance = new ChromeDriver(options);
            }
            instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return instance;
        }

        public static void Quit()
        {
            if (instance != null)
            {
                instance.Quit();
                instance = null;
            }
        }
    }
}
