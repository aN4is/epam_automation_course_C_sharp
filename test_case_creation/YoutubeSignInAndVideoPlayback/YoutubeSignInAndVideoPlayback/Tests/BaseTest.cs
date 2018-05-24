using NUnit.Framework;
using System;
using YoutubeSignInAndVideoPlayback.WebDriver;

namespace YoutubeSignInAndVideoPlayback.Tests
{
    public abstract class BaseTest
    {
        private const int TimeoutSec = 5;       

        [SetUp]
        public void Initialize()
        {
            Driver.GetDriver();
            Driver.GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TimeoutSec);
        }

        [TearDown]
        public void EndTest()
        {
            Driver.Quit();            
        }
    }
    //before test - navigate
    //after - log out (if logged in)
}
