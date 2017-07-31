using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace Framework.Driver
{
    /// <summary>
    /// Manage Driver entites to provide parallel running by tests
    /// </summary>
    public class DriverManager
    {
        /// <summary>
        /// Contains as key name of test class and as a value appropriate driver for earch tests
        /// </summary>
        private static Dictionary<string, IWebDriver> listOfDrivers = new Dictionary<string, IWebDriver>();

        private DriversType type;
  
        public IWebDriver Driver
        {
            get
            {
                if (!listOfDrivers.ContainsKey(TestContext.CurrentContext.Test.ClassName))
                {
                    listOfDrivers.Add(TestContext.CurrentContext.Test.ClassName, BrowserFactory.InitBrowser(type));
                }
                IWebDriver result;
                listOfDrivers.TryGetValue(TestContext.CurrentContext.Test.ClassName, out result);
                return result;
            }

        }

        public static DriverManager DriverInstanse;


        private DriverManager(DriversType type)
        {
            this.type = type;
        }

        /// <summary>
        /// Set type of driver
        /// </summary>
        /// <param name="type">return manager of driver to provide access to driver</param>
        /// <returns></returns>
        public static DriverManager SetDriver(DriversType type)
        {
            if (DriverInstanse == null)
            {
                DriverInstanse = new DriverManager(type);
            }
            return DriverInstanse;
        }

        /// <summary>
        /// Close all drivers
        /// </summary>
        public void Quit()
        {
            Driver.Quit();
            listOfDrivers.Remove(TestContext.CurrentContext.Test.ClassName);
        }
    }
}
