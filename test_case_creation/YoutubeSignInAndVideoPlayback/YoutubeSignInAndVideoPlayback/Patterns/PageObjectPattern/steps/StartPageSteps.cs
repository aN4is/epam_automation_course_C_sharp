
using YoutubeSignInAndVideoPlayback.WebDriver;

namespace YoutubeSignInAndVideoPlayback.pages.PageObjectPattern.steps
{
    class StartPageSteps : BasePageSteps
    {
        StartPage startPage = new StartPage(Driver.GetDriver());

        public void OpenSignInPage()
        {
            
            startPage.ClickSignInButton();
            //return new SignInPage(Driver);
        }

        public void OpenYoutubeUrl()
        {
            startPage.OpenUrl();
        }

    }
}
