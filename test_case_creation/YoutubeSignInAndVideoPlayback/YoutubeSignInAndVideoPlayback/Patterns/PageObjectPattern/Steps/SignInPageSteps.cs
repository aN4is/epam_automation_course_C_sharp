using YoutubeSignInAndVideoPlayback.Data.Users;
using YoutubeSignInAndVideoPlayback.Patterns.PageObjectPattern.Pages;

namespace YoutubeSignInAndVideoPlayback.Patterns.PageObjectPattern.Steps
{
    class SignInPageSteps : BasePageSteps
    {
        private SignInPage signInPage = new SignInPage();

        public void SignInToYouTube(Users user)
        {
            signInPage.EnterUsername(user.Username);
            signInPage.ClickNextButton();
            signInPage.EnterPassword(user.Password);
            signInPage.ClickDoneButton();
        }
    }
}
