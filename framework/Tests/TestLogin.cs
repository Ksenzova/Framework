﻿using Framework.Driver;
using Framework.LogicSteps;
using Framework.Pages;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    [Parallelizable]
    public class TestLogin : BaseTest
    {
        LoginPage loginPage;
        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            Driver = DriverManager.DriverInstanse.Driver;
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://journals.lww.com");
            loginPage = new LoginPage();
        }

        [TestCase("", "", TestName = "TestLoginEmptyInput")]
        [TestCase("Ksenvov", "", TestName = "TestLoginEmptyInputPassword")]
        [TestCase("", "Qwerty1235", TestName = "TestLoginEmptyInputLogin")]
        [TestCase("user", "password", TestName = "TestLoginInvalidInput")]
        [Category("Login")]
        public void TestLoginIsFailed(string user, string password)
        {
            LoginSteps.Login(loginPage, user, password);
            Assert.IsTrue(loginPage.ErrorMessage.Enabled);
        }

        [Test]
        [Category("Login")]
        public void TestLoginIsPass()
        {
            User = "Ksenvov";
            Password = "Qwerty12345";
            LoginSteps.Login(loginPage, User, Password);
            Assert.IsTrue(loginPage.LogOutLink.Displayed);
        }

        [TearDown]
        [Category("Login")]
        public void AfterTest()
        {
            DriverManager.DriverInstanse.Quit();
        }
    }
}
