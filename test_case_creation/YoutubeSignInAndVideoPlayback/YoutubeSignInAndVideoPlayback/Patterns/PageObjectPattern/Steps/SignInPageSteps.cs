namespace YoutubeSignInAndVideoPlayback.pages.PageObjectPattern.steps
{
    class SignInPageSteps : BasePageSteps
    {
        SignInPage signInPage = new SignInPage();

        public void SignInToYouTube(string username, string password)
        {
            signInPage.EnterUsername(username);
            signInPage.ClickNextButton();
            signInPage.EnterPassword(password);
            signInPage.ClickDoneButton();
        }
    }
}
