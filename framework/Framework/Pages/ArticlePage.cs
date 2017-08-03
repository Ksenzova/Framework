using OpenQA.Selenium;

namespace Framework.Pages
{
    /// <summary>
    /// Describe Article main elements of article page
    /// </summary>
    public class ArticlePage : BasePage
    {
        private static By addToFavoriteButtonsLocator = By.XPath("//section[contains(@id,'ArticleTools')]//*[text()='Add to My Favorites']");

        public Element AddToFavoriteButtons = new Element(addToFavoriteButtonsLocator, "Add to favorite button");
    }
}