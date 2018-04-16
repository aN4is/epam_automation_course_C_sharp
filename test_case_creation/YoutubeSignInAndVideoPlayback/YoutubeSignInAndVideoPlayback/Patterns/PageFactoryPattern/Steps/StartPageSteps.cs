using YoutubeSignInAndVideoPlayback.Patterns.PageFactoryPattern.Pages;

namespace YoutubeSignInAndVideoPlayback.pages.PageFactoryPattern.steps
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
