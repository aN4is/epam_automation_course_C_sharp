using YoutubeSignInAndVideoPlayback.Data.Users;
using YoutubeSignInAndVideoPlayback.Patterns.PageFactoryPattern.Pages;

namespace YoutubeSignInAndVideoPlayback.Patterns.PageFactoryPattern.Steps
{
    class SignInPageSteps : BasePageSteps
    {
        private SignInPage signInPage = new SignInPage(driver);

        public void SignInToYouTube(Users user)
        {
            signInPage.EnterUsername(user.Username);
            signInPage.ClickNextButton();
            signInPage.EnterPassword(user.Password);
            signInPage.ClickDoneButton();
        }
    }
}
