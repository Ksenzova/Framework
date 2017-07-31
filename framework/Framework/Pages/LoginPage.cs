using OpenQA.Selenium;

namespace Framework.Pages
{
    /// <summary>
    /// Describe Maine elements ogf llogin form
    /// </summary>
    public class LoginPage : BasePage
    {
        private static By userLocator = By.XPath("//input[contains(@name,'UserName')]");
        private static By passwordLocator = By.XPath("//*[contains(@class,'login')]//input[contains(@name,'Password')]");
        private static By submitButtonLocator = By.XPath("//input[contains(@name,'LoginButton')]");
        private static By logOutLinkLocator = By.XPath("//*[contains(@id, 'Logout')]");
        private static By errorLinkLocator = By.XPath("//*[contains(@class,'error')]");

        public Element User = new Element(userLocator, "User box");
        public Element Password = new Element(passwordLocator,"Password box");
        public Element Submit = new Element(submitButtonLocator,"Submit button");
 
        public Element LogOutLink = new Element(logOutLinkLocator,"Log out link");
        public Element ErrorMessage = new Element(errorLinkLocator,"Error message");      
    }
}
