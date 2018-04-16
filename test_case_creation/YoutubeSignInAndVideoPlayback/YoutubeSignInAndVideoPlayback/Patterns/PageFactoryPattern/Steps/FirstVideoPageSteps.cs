using YoutubeSignInAndVideoPlayback.Patterns.PageFactoryPattern.Pages;

namespace YoutubeSignInAndVideoPlayback.pages.PageFactoryPattern.steps
{
    class FirstVideoPageSteps : BasePageSteps
    {
        private FirstVideoPage firstVideoPage = new FirstVideoPage(driver);

        public void SignOutFromYouTube()
        {
            firstVideoPage.ClickAvatarButton();
            firstVideoPage.ClickSignOutButton();
        }
    }
}
