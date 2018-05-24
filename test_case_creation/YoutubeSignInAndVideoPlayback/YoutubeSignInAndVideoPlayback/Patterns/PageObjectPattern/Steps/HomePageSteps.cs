using YoutubeSignInAndVideoPlayback.Patterns.PageObjectPattern.Pages;

namespace YoutubeSignInAndVideoPlayback.Patterns.PageObjectPattern.Steps
{
    class HomePageSteps : BasePageSteps
    {
        private HomePage homePage = new HomePage();

        public void SelectFirstVideoInTheGrid(string search_string)
        {
            homePage.SearchForRequiredVideo(search_string);
            homePage.ClickFirstVideoInGrid();
        }
    }
}
