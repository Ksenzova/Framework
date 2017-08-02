using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using System.Collections.ObjectModel;
using System.Drawing;
using Framework.Driver;

namespace Framework
{
    /// <summary>
    /// Implement all method of IWebElement and add add waiting for each
    /// </summary>
    public class Element :IWebElement
    {
        public string Name { get; }      
        public By Locator { get; }
        private WebDriverWait wait;
        private IWebDriver driver;

        public Element(By Locator, string name)
        {
            this.Locator = Locator;
            this.driver = DriverManager.DriverInstanse.Driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(int.Parse(ConfigurationManager.AppSettings["Time"])));
        }

        public void WaitElement()
        {
            wait.Until(ExpectedConditions.ElementExists(this.Locator));
        }

        public bool Displayed
        {
            get
            {
                WaitElement();
                return driver.FindElement(this.Locator).Displayed;
            }
        }

        public bool Enabled
        {
            get
            {
                WaitElement();
                return driver.FindElement(this.Locator).Enabled;
            }
        }

        public Point Location
        {
            get
            {
                WaitElement();
                return driver.FindElement(this.Locator).Location;
            }
        }

        public bool Selected
        {
            get
            {
                WaitElement();
                return driver.FindElement(this.Locator).Selected;
            }
        }

        public Size Size
        {
            get
            {
                WaitElement();
                return driver.FindElement(this.Locator).Size;
            }
        }

        public string TagName
        {
            get
            {
                WaitElement();
                return driver.FindElement(this.Locator).TagName;
            }
        }

        public string Text
        {
            get
            {
                WaitElement();
                return driver.FindElement(this.Locator).Text;
            }
        }

        public void Clear()
        {
            WaitElement();
            driver.FindElement(this.Locator).Clear();
        }

        public void Click()
        {
            Logger.Info(string.Concat(Name," Click"));
            WaitElement();
            driver.FindElement(this.Locator).Click();
        }

        public IWebElement FindElement()
        {
            WaitElement();
            return driver.FindElement(this.Locator);
        }

        public ReadOnlyCollection<IWebElement> FindElements()
        {
            WaitElement();
            return driver.FindElements(this.Locator);
        }

        public string GetAttribute(string attributeName)
        {
            WaitElement();
            return driver.FindElement(this.Locator).GetAttribute(attributeName);
        }

        public string GetCssValue(string propertyName)
        {
            WaitElement();
            return driver.FindElement(this.Locator).GetCssValue(propertyName);
        }

        public void SendKeys(string text)
        {
            WaitElement();
            Logger.Info(string.Concat(Name, ":  SendKey ", text));
            driver.FindElement(this.Locator).SendKeys(text);
        }

        public void Submit()
        {
            WaitElement();
            Logger.Info(string.Concat(Name, ":  Submit"));
            driver.FindElement(this.Locator).Submit();
        }

        public IWebElement FindElement(By by)
        {
            return FindElement();
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return FindElements();
        }
    }
}
