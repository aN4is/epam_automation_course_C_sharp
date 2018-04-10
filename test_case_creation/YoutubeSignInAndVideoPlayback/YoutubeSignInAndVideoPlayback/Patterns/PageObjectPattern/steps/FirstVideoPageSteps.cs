using YoutubeSignInAndVideoPlayback.WebDriver;

namespace YoutubeSignInAndVideoPlayback.pages.PageObjectPattern.steps
{
    class FirstVideoPageSteps : BasePageSteps
    {
        FirstVideoPage firstVideoPage = new FirstVideoPage(Driver.GetDriver());

        public void SignOutFromYouTube()
        {
            firstVideoPage.ClickAvatarButton();
            firstVideoPage.ClickSignOutButton();
        }
    }
}
