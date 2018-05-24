using YoutubeSignInAndVideoPlayback.Patterns.PageFactoryPattern.Pages;

namespace YoutubeSignInAndVideoPlayback.Patterns.PageFactoryPattern.Steps
{
    class StartPageSteps : BasePageSteps
    {
        private StartPage startPage = new StartPage(driver);

        public void OpenSignInPage()
        {            
            startPage.ClickSignInButton();           
        }

        public void OpenYoutubeUrl()
        {
            startPage.OpenUrl();
        }

    }
}
