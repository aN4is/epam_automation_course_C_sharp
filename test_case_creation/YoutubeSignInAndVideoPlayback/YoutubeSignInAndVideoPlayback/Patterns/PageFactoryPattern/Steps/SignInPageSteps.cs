using YoutubeSignInAndVideoPlayback.Patterns.PageFactoryPattern.Pages;

namespace YoutubeSignInAndVideoPlayback.pages.PageFactoryPattern.steps
{
    class SignInPageSteps : BasePageSteps
    {
        private SignInPage signInPage = new SignInPage(driver);

        public void SignInToYouTube(string username, string password)
        {
            signInPage.EnterUsername(username);
            signInPage.ClickNextButton();
            signInPage.EnterPassword(password);
            signInPage.ClickDoneButton();
        }
    }
}
