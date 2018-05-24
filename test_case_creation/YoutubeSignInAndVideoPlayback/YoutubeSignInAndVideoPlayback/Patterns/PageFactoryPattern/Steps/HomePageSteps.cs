using YoutubeSignInAndVideoPlayback.Patterns.PageFactoryPattern.Pages;

namespace YoutubeSignInAndVideoPlayback.Patterns.PageFactoryPattern.Steps
{
    class HomePageSteps : BasePageSteps
    {
        private HomePage homePage = new HomePage(driver);

        public void SelectFirstVideoInTheGrid(string search_string)
        {
            homePage.SearchForRequiredVideo(search_string);
            homePage.ClickFirstVideoInGrid();
        }
    }
}
