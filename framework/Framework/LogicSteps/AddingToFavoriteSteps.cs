using Framework.Pages;
using System.Reflection;

namespace Framework.LogicSteps
{
    public  class AddingToFavoriteSteps : BaseStep
    {
        public static string Journal;
        public static string FirstArticleTitle;
        public static string FolderName;

        public static void GoToFirstJournal(ListOfJournalsPage listPage)
        {
            Start(MethodBase.GetCurrentMethod().Name);         
            Journal = listPage.FirstJournal.Text;
            listPage.FirstJournal.Click();
            Stop(MethodBase.GetCurrentMethod().Name);
        }

        public static void ClickFavorite(CurrentJournalPage current)
        {
            Start(MethodBase.GetCurrentMethod().Name);
            FirstArticleTitle = current.Articles.FindElements()[0].GetAttribute("title");
            current.FavoriteButton.Click();
            Stop(MethodBase.GetCurrentMethod().Name);
        }

        public static void GoToListOfArticles(CurrentJournalPage page, ArticlePage articlePage)
        {
            Start(MethodBase.GetCurrentMethod().Name);
            FirstArticleTitle = page.Articles.FindElements()[0].GetAttribute("title");
            page.Articles.FindElements()[0].Click();
            articlePage.AddToFavoriteButtons.FindElements()[1].Click();
            Stop(MethodBase.GetCurrentMethod().Name);
        }

        public static void ToNewFolder(SelectFolderForm form, string folderName)
        {
            Start(MethodBase.GetCurrentMethod().Name);

            form.NewFolderButton.Click();
            if (!form.NewFolderBox.Enabled)
            {
                form.NewFolderButton.Click();
            }
            form.NewFolderBox.Clear();
            form.NewFolderBox.SendKeys(folderName);
            form.NewFolderButton.Click();
            FolderName = folderName;
            form.SubmitButton.Click();
            form.GoToMyFavoriteButton.Click();
            Stop(MethodBase.GetCurrentMethod().Name);
        }

        public static void ToExistingFolder(SelectFolderForm form)
        {
            Start(MethodBase.GetCurrentMethod().Name);
            form.ExistingFolderButton.Click();
            FolderName = form.ExistingFoldersBox.FindElements()[0].Text;
            form.SubmitButton.Click();
            form.GoToMyFavoriteButton.Click();
            Stop(MethodBase.GetCurrentMethod().Name);
        }


        public static bool IsAddedRight(MyFavoritePage page, string folder, string article)
        {
            Start(MethodBase.GetCurrentMethod().Name);
            return page.IsRightFolder(folder) && page.IsExistArticle(article);
            Stop(MethodBase.GetCurrentMethod().Name);
        }

        public static void Delete(MyFavoritePage page)
        {
            Start(MethodBase.GetCurrentMethod().Name);
            page.DeleteButton.Click();
            page.ConfirmDeleteButton.Click();
            Stop(MethodBase.GetCurrentMethod().Name);
        }
    }
}
