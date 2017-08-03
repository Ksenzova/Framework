using Framework.Driver;
using Framework.Pages;
using OpenQA.Selenium;

namespace Framework.LogicSteps
{
    public class SearchSteps
    {
        public static int resultsOnCurrentPage;
        public static int allResults;
        public static void Login(CurrentJournalPage page, LoginPage loginPage, string user, string password)
        {
            Logger.Info("Started login step");
            page.LoginButton.Click();
            loginPage = new LoginPage();
            LoginSteps.Login(loginPage, user, password);
            Logger.Info("Started login step");
        }

        public static  void FindByKeyWord(CurrentJournalPage current, AdvansedSearchPage advansed,string keyWord)
        {
            current.AdvansedSearchLink.Click();
            advansed.SearchBox.SendKeys(keyWord);
            advansed.Submit.Click();
        }

        public static void CalculateResults(ResultSearchPage page)
        {
            resultsOnCurrentPage = page.Articles.FindElements().Count;
            allResults = int.Parse(page.CountAllResults.Text.Split(' ')[0]);
        }

        public static void GoToNextPage(ResultSearchPage page)
        {
            page.NextPageButton.Click();
        }

        public static void FindBy(CurrentJournalPage current, AdvansedSearchPage page, string keyWords)
        {
            current.AdvansedSearchLink.Click();
            page.BoxToEnteTitle.SendKeys(keyWords);
            page.SearchButton.Click();
        }
        public static bool IsExistTitle(ResultSearchPage resultPage, string title)
        {
            return resultPage.IsTitleExist(title);
        }

        public static void SaveSearch(ResultSearchPage resultPage, SaveSearchForm form, string searchName)          
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)DriverManager.DriverInstanse.Driver;
            js.ExecuteScript("arguments[0].click()", resultPage.ButtonToSaveSearch.FindElement());
            form.SearchNameBox.SendKeys(searchName);
            form.SaveSearchButton.Click();
            form.CloseWindowButton.Click();
        }

        public static void GoToMyFavorites(ResultSearchPage resultPage)
        {
            resultPage.UserActionXpath.Click();
            resultPage.GoToMyFavoritesAction.Click();
        }

        public static string GetSearchKeyWords(MyFavoritePage page, ResultSearchPage resultPage , string search)
        {
            page.IsRightFolder("Saved Searches");
            page.GoToSearch(search);
            return resultPage.UsedSearchKeyWords.Text;
        }
        
    }
}
