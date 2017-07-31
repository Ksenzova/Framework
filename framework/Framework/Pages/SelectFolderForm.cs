using OpenQA.Selenium;

namespace Framework.Pages
{
    /// <summary>
    /// Describe select folder form
    /// </summary>
    public class SelectFolderForm : BasePage
    {
        private static By existingFolderRadioButtonLocator = By.XPath("//input[contains(@id,'ExistingCollection')]");
        private static By existingFoldersLocator = By.XPath("//select[contains(@id,'ExistingCollection')]//option");
        private static By newFolderRadioButtonLocator = By.XPath("//input[contains(@id,'NewCollection')]");
        private static By newFolderNameLocator = By.XPath("//input[contains(@id,'CollectionName')]");
        private static By submitButtonLocator = By.XPath("//input[contains(@value,'Add Item')]");
        private static By goToMyCollectionButtonLocator = By.XPath("//input[contains(@value,'My Favorites')]");
        private static By chooseAnotherNameMessageLocator = By.XPath("//*[contains(text(),'choose another name')]");

        public Element ExistingFolderButton = new Element(existingFolderRadioButtonLocator, "Existing folder radio button");
        public Element ExistingFoldersBox = new Element(existingFoldersLocator, "Existing folders box");
        public Element NewFolderButton = new Element(newFolderRadioButtonLocator, "New bow Radio button");
        public Element NewFolderBox = new Element(newFolderNameLocator, "New folder box");
        public Element SubmitButton = new Element(submitButtonLocator, "Submit button");
        public Element GoToMyFavoriteButton = new Element(goToMyCollectionButtonLocator, "Go to me fovorites button");     
    }
}