using YoutubeSignInAndVideoPlayback.WebDriver;

namespace YoutubeSignInAndVideoPlayback.pages.PageObjectPattern.steps
{
    class HomePageSteps : BasePageSteps
    {
        HomePage homePage = new HomePage(Driver.GetDriver());

        public void SelectFirstVideoInTheGrid(string search_string)
        {
            homePage.SearchForRequiredVideo(search_string);
            homePage.ClickFirstVideoInGrid();
        }
    }
}
