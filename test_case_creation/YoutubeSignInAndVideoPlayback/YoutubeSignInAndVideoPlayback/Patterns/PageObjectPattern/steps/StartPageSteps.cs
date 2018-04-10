
using YoutubeSignInAndVideoPlayback.WebDriver;

namespace YoutubeSignInAndVideoPlayback.pages.PageObjectPattern.steps
{
    class StartPageSteps : BasePageSteps
    {
        StartPage startPage = new StartPage(Driver.GetDriver());

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
