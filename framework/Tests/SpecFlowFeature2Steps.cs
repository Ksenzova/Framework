using Framework.Driver;
using Framework.LogicSteps;
using Framework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Tests
{
    [Binding]
    public class SpecFlowFeature2Steps : BaseTest
    {
        [Given(@"I go to home page")]
        public void GivenIGoToHomePage()
        {
            base.SetUp();
            Driver = DriverManager.DriverInstanse.Driver;
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://journals.lww.com");
            LoginPage = new LoginPage();
        }
        
        [Given(@"I enter (.*) and (.*)")]
        public void GivenIEnterKsenvovAndQwerty(string user, string password)
        {
            LoginSteps.Login(LoginPage, user, password);
           
        }
        
        [Then(@"I see user account")]
        public void ThenISeeUserAccount()
        {
            Assert.IsTrue(LoginPage.ErrorMessage.Enabled);
        }
        
        [Then(@"Close Browser")]
        public void ThenLogout()
        {
            DriverManager.DriverInstanse.Quit();
        }
    }
}
