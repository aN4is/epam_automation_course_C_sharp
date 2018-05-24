using NUnit.Framework;
using YoutubeSignInAndVideoPlayback.Data.Strings;
using YoutubeSignInAndVideoPlayback.Data.Users;
using YoutubeSignInAndVideoPlayback.Patterns.PageObjectPattern.Steps;

namespace YoutubeSignInAndVideoPlayback.Tests
{
    class PageObjectTest : BaseTest
    {
        private StartPageSteps      startPageSteps      = new StartPageSteps();
        private SignInPageSteps     signInPageSteps     = new SignInPageSteps();
        private HomePageSteps       homePageSteps       = new HomePageSteps();
        private FirstVideoPageSteps firstVideoPageSteps = new FirstVideoPageSteps();

        [Test]
        public void YoutubeSignInAndVideoPlaybackTest_PageObject()
        {
            var validUser = new Users().ValidUser();
            startPageSteps.OpenYoutubeUrl();
            startPageSteps.OpenSignInPage();
            signInPageSteps.SignInToYouTube(validUser);
            homePageSteps.SelectFirstVideoInTheGrid(Strings.SEARCH_STRING1);
            
            var actualPageTitle = firstVideoPageSteps.GetPageTitle(Strings.EXPECTED_PAGE_TITLE1);

            Assert.AreEqual(Strings.EXPECTED_PAGE_TITLE1, actualPageTitle);
            firstVideoPageSteps.SignOutFromYouTube();         
        }

    }
}
