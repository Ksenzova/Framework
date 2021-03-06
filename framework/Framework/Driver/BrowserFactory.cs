﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace Framework.Driver
{
    /// <summary>
    /// Return appropriate type of driver
    /// </summary>
    public class BrowserFactory
    {
        private static IWebDriver driver;

        public static IWebDriver InitBrowser(DriversType type)
        {
            switch (type)
            {
                case DriversType.Firefox:
                     driver = new FirefoxDriver();
                    break;           
                case DriversType.Edge:
                     driver = new EdgeDriver();
                    break;
                case DriversType.Chrome:
                    driver = new ChromeDriver();
                    break;
            }
            return driver;
        }      
    }
}