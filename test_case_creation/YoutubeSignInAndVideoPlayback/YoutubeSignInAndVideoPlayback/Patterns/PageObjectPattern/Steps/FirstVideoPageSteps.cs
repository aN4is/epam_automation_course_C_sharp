using YoutubeSignInAndVideoPlayback.Patterns.PageObjectPattern.Pages;

namespace YoutubeSignInAndVideoPlayback.Patterns.PageObjectPattern.Steps
{
    class FirstVideoPageSteps : BasePageSteps
    {
        private FirstVideoPage firstVideoPage = new FirstVideoPage();

        public void SignOutFromYouTube()
        {
            firstVideoPage.ClickAvatarButton();
            firstVideoPage.ClickSignOutButton();
        }
    }
}
