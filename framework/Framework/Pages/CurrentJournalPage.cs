using OpenQA.Selenium;

namespace Framework.Pages
{
    /// <summary>
    /// Discribe current journal page
    /// </summary>
    public class CurrentJournalPage : BasePage
    {
        private static By favoriteButtonsLocator = By.XPath("//div[contains(@id,'List')]//*[contains(text(),'Favorites')]");
        private static By articlesLocator = By.XPath("//*[contains(@id,'ListContainer')]//header//*[@title]");
        private static By loginButtonLocator = By.XPath("//*[contains(@class,'header-right')]//*[contains(text(),'Login')]");
        private static By advanceSearchLocator = By.XPath("//*[contains(@id,'AdvanceSearch')]");

        public Element FavoriteButton = new Element(favoriteButtonsLocator , "Favorite button");
        public Element Articles = new Element(articlesLocator , "Articles ");
        public Element LoginButton = new Element(loginButtonLocator, "Login button");
        public Element AdvansedSearchLink = new Element(advanceSearchLocator, "Advansed search link");
    }
}
