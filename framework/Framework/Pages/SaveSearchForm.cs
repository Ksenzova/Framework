using OpenQA.Selenium;

namespace Framework.Pages
{
    /// <summary>
    /// Describe form to save searh
    /// </summary>
    public class SaveSearchForm : BasePage
    {
        private static By searchNameBoxLocator = By.XPath("//input[contains(@type,'text') and contains(@id,'SaveSearch')]");
        private static By saveSearchButtonLocator = By.XPath("//input[contains(@type,'submit') and contains(@value,'Search')]");
        private static By closeWindowButtonLocator = By.XPath("//button[contains(@onclick,'close')]");

        public Element SearchNameBox = new Element(searchNameBoxLocator, "Search name box");
        public Element SaveSearchButton = new Element(saveSearchButtonLocator, "Save search button");
        public Element CloseWindowButton = new Element(closeWindowButtonLocator, "Close window button");
    }
}
