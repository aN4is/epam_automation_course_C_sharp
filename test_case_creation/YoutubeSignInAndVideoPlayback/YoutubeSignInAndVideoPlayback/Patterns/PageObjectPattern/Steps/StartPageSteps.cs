using YoutubeSignInAndVideoPlayback.Patterns.PageObjectPattern.Pages;

namespace YoutubeSignInAndVideoPlayback.Patterns.PageObjectPattern.Steps

{
    class StartPageSteps : BasePageSteps
    {
        private StartPage startPage = new StartPage();

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
