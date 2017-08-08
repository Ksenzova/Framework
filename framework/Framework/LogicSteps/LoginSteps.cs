﻿using Framework.Pages;
using System.Reflection;
using System;

namespace Framework.LogicSteps
{
    public class LoginSteps : BaseStep
    {
        public static void Login(LoginPage page, string user, string password)
        { 
            Start(MethodBase.GetCurrentMethod().Name);
            page.User.Clear();
            page.User.SendKeys(user);
            page.Password.Clear();
            page.Password.SendKeys(password);
            page.Submit.Click();
            Stop(MethodBase.GetCurrentMethod().Name);
        }

        public static void Login(LoginPage loginPage, object user, object password)
        {
            throw new NotImplementedException();
        }
    }
}
