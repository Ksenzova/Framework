using Framework.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Framework.Pages
{
    public class ResultSearchPage :BasePage
    {
        private By articlesSearchXpath = By.XPath("//*[contains(@class,'articles')]//article");
        private By countResultXpath = By.XPath("//*[contains(@class,'resultCount')]");
        private By toNextPageButtonXpath = By.XPath("//*[contains(@id,'nextLink')]");
        private By titlesOfSearchedElementsXpath = By.XPath("//*[contains(@class,'searchContent')]//header//*[@title]");
        private By buttonToSaveSearchXpath = By.XPath("//*[contains(@class,'savedSearchClass')]//input[contains(@value,'Save Search')]");
        public By linkToGoToMySearhesXpath = By.XPath("//*[contains(@class,'mySaved')]");
        private By usedSearchKeyWordsXpath = By.XPath("//*[contains(@id,'userKeyWords')]");
        private By userActionsXpath = By.XPath("//*[contains(@id,'UserAccount')]");
        private By goToMyFavoritesXpath = By.XPath(" //*[contains(@id,'AccountActions')]//*[contains(@id,'MyFavorites') and contains(text(),'Favorites')]");

        public Element Articles;
        public Element CountAllResults;
        public Element NextPageButton;
        public Element TitleOFArticles;
        public Element ButtonToSaveSearch;
        public Element LinkToGoToMyFavorites;
        public Element UsedSeardhKeyWords;
        public Element UserActionXpath;
        public Element GoToMyFavoritesAction;

        public ResultSearchPage()
        {
            Driver = DriverManager.DriverInstanse.Driver;
            Articles = new Element(Driver, articlesSearchXpath);
            CountAllResults = new Element(Driver, countResultXpath);
            NextPageButton = new Element(Driver, toNextPageButtonXpath);
            TitleOFArticles = new Element(Driver, titlesOfSearchedElementsXpath);
            ButtonToSaveSearch = new Element(Driver, buttonToSaveSearchXpath);
            UserActionXpath = new Element(Driver, userActionsXpath);
            GoToMyFavoritesAction = new Element(Driver, goToMyFavoritesXpath);
            UsedSeardhKeyWords = new Element(Driver, usedSearchKeyWordsXpath);           
        }

        public bool IsTitleExist(string title)
        {
            bool IsExist = false;
            foreach (var elem in TitleOFArticles.FindElements())
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
