using OpenQA.Selenium;

namespace Framework.Pages
{
    /// <summary>
    /// Describe main elements of page witch contains list of journals
    /// </summary>
    public class ListOfJournalsPage : BasePage
    {
        private static  By journalLocator = By.XPath("//*[contains(@id,'ListContainer')]//a[1]");

        public Element FirstJournal  = new Element(journalLocator, "First journal");
    }
}