using Framework.Driver;
using Framework.LogicSteps;
using Framework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Tests
{
    [TestFixture]
    [Parallelizable]
    public class TestSearch : BaseTest
    {
        LoginPage loginPage;
        CurrentJournalPage current;
        AdvansedSearchPage advansedSearchPage;
        ResultSearchPage resultPage;
        MyFavoritePage myFavoritePage;
        SaveSearchForm saveForm;

        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            Driver = DriverManager.DriverInstanse.Driver;
            Driver.Navigate().GoToUrl("http://journals.lww.com/plasreconsurg/pages/default.aspx");
            Driver = DriverManager.DriverInstanse.Driver;
            Driver.Manage().Window.Maximize();
            loginPage = new LoginPage();
            current = new CurrentJournalPage();
            advansedSearchPage = new AdvansedSearchPage();
            resultPage = new ResultSearchPage();
            myFavoritePage = new MyFavoritePage();
            saveForm = new SaveSearchForm();
            SearchSteps.Login(current, loginPage, "Ksenvov", "Qwerty12345");
        }

        [Test]
        [Category("Search")]
        public void TestCountResultsOnCurrentPage()
        {
            SearchSteps.FindByKeyWord(current, advansedSearchPage, "blood");
            SearchSteps.CalculateResults(resultPage);
            Assert.IsTrue(SearchSteps.resultsOnCurrentPage > 20);
            Assert.IsTrue(SearchSteps.allResults > 100);
        }

        [Test]
        [Category("Search")]
        public void TestCountResultsOnNextPage()
        {
            SearchSteps.FindByKeyWord(current, advansedSearchPage, "blood");
            SearchSteps.CalculateResults(resultPage);
            SearchSteps.GoToNextPage(resultPage);
            Assert.IsTrue(SearchSteps.resultsOnCurrentPage > 20);
        }

        [Test]
        [Category("Search")]
        public void TestFindByTitle()
        {
            string titleExample = "Blood Supply and Skeletal Muscle Infarction";
            SearchSteps.FindBy(current, advansedSearchPage, titleExample);
            Assert.IsTrue(SearchSteps.IsExistTitle(resultPage, titleExample));

        }

        [Test]
        [Category("Search")]
        public void TestSaveSearch()
        {
            string titleExample = "Blood Supply and Skeletal Muscle Infarction";
            SearchSteps.FindBy(current, advansedSearchPage, titleExample);
            SearchSteps.SaveSearch(resultPage, saveForm, "new1");
            SearchSteps.GoToMyFavorites(resultPage);
            string result = SearchSteps.GetSearchKeyWords(myFavoritePage, resultPage, "new1");
            Assert.IsTrue(result.Contains(titleExample));
        }

        [Test]
        [Category("Search")]
        public void TestOpenSearch()
        {
            string titleExample = "Blood Supply and Skeletal Muscle Infarction";
            SearchSteps.GoToMyFavorites(resultPage);
            string result = SearchSteps.GetSearchKeyWords(myFavoritePage, resultPage, "new");
            Assert.IsTrue(result.Contains(titleExample));
        }

        [TearDown]
        public void AfterTest()
        {
           // DriverManager.DriverInstanse.Quit();
        }
    }
}
