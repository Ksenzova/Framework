using Framework.Driver;
using OpenQA.Selenium;

namespace Framework.Pages
{
    public class ResultSearchPage :BasePage
    {
        private static By articlesSearchLocator = By.XPath("//*[contains(@class,'articles')]//article");
        private static By countResultLocator = By.XPath("//*[contains(@class,'resultCount')]");
        private static By toNextPageButtonLocator = By.XPath("//*[contains(@id,'nextLink')]");
        private static By titlesOfSearchedElementsLocator = By.XPath("//*[contains(@class,'searchContent')]//header//*[@title]");
        private static By buttonToSaveSearchLocator = By.XPath("//*[contains(@class,'savedSearchClass')]//input[contains(@value,'Save Search')]");
        private static By usedSearchKeyWordsLocator = By.XPath("//*[contains(@id,'userKeyWords')]");
        private static By userActionsLoactor = By.XPath("//*[contains(@id,'UserAccount')]");
        private static By goToMyFavoritesLoactor = By.XPath(" //*[contains(@id,'AccountActions')]//*[contains(@id,'MyFavorites') and contains(text(),'Favorites')]");

        public Element Articles = new Element(articlesSearchLocator, "Arcticles");
        public Element CountAllResults = new Element( countResultLocator,"Count all found articles");
        public Element NextPageButton = new Element( toNextPageButtonLocator, "Next page button");
        public Element TitlesOfArticles = new Element(titlesOfSearchedElementsLocator, "Next page button");

        public Element ButtonToSaveSearch = new Element(buttonToSaveSearchLocator, "Button to save search");
        public Element UsedSearchKeyWords = new Element( usedSearchKeyWordsLocator, "Used key words");
        public Element UserActionXpath = new Element( userActionsLoactor, "User actions");
        public Element GoToMyFavoritesAction = new Element( goToMyFavoritesLoactor, "Go to favorites action");

        public ResultSearchPage()
        {
            Driver = DriverManager.DriverInstanse.Driver;          
        }

        public bool IsTitleExist(string title)
        {
            bool IsExist = false;
            foreach (var elem in TitlesOfArticles.FindElements())
            {
                if (elem.Text == title)
                {
                    IsExist = true;
                    break;
                }
            }
            return IsExist;
        }
    }
}
