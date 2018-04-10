using NUnit.Framework;
using YoutubeSignInAndVideoPlayback.pages.PageObjectPattern.steps;
using YoutubeSignInAndVideoPlayback.WebDriver;

namespace YoutubeSignInAndVideoPlayback.tests
{
    class PageObjectTest
    {
        private const string USERNAME = "mattaku.ad@gmail.com";
        private const string PASSWORD = "Q!w2e3r4";
        private const string SEARCH_STRING = "gnossienne 1 piano";
        private const string EXPECTED_PAGE_TITLE = "ERIK SATIE Gnossienne 1 - Alessio Nanni, piano - YouTube";

        StartPageSteps startPageSteps = new StartPageSteps();
        SignInPageSteps signInPageSteps = new SignInPageSteps();
        HomePageSteps homePageSteps = new HomePageSteps();
        FirstVideoPageSteps firstVideoPageSteps = new FirstVideoPageSteps();



        [Test]
        public void YoutubeSignInAndVideoPlaybackTest_PageObject()
        {
            startPageSteps.OpenYoutubeUrl();
            startPageSteps.OpenSignInPage();
            signInPageSteps.SignInToYouTube(USERNAME, PASSWORD);
            homePageSteps.SelectFirstVideoInTheGrid(SEARCH_STRING);
            
            string actualPageTitle = firstVideoPageSteps.GetPageTitle(EXPECTED_PAGE_TITLE);

            Assert.AreEqual(EXPECTED_PAGE_TITLE, actualPageTitle);
            firstVideoPageSteps.SignOutFromYouTube();
            Driver.Quit();

        }

    }
}
