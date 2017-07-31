using OpenQA.Selenium;

namespace Framework.Pages
{
    /// <summary>
    /// Describe main elements of advansed search page
    /// </summary>
    public class AdvansedSearchPage :BasePage
    {
        private static By enterKeyWordsBoxLocator = By.XPath("//input[contains(@value,'Keywords')]");
        private static By submitSearchButtonLocator = By.XPath("//button[contains(@id,'Search')]");
        private static By exterTiteleBoxLoactor = By.XPath("//*[contains(@id,'advancedSearch')]//input[contains(@id,'keywords') and contains(@id,'2')]");
        private static By searchButtonStartLocator = By.XPath("//input[contains(@type,'submit') and contains(@value,'Search')]");

        public Element SearchBox = new Element(enterKeyWordsBoxLocator, "Search box");
        public Element Submit = new Element(submitSearchButtonLocator, " Submit search button");
        public Element BoxToEnteTitle = new Element(exterTiteleBoxLoactor, "Title box");
        public Element SearchButton = new Element(searchButtonStartLocator , "Search button");
    }
}
