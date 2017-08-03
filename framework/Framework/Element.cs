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
        public string name;
        public By locator;
        private WebDriverWait wait;
        private IWebDriver driver;

        public Element(By Locator, string name)
        {
            this.locator = Locator;
            this.driver = DriverManager.DriverInstanse.Driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(int.Parse(ConfigurationManager.AppSettings["Time"])));
        }

        public void WaitElement()
        {
            wait.Until(ExpectedConditions.ElementExists(this.locator));
        }

        public bool Displayed
        {
            get
            {
                WaitElement();
                return driver.FindElement(this.locator).Displayed;
            }
        }

        public bool Enabled
        {
            get
            {
                WaitElement();
                return driver.FindElement(this.locator).Enabled;
            }
        }

        public Point Location
        {
            get
            {
                WaitElement();
                return driver.FindElement(this.locator).Location;
            }
        }

        public bool Selected
        {
            get
            {
                WaitElement();
                return driver.FindElement(this.locator).Selected;
            }
        }

        public Size Size
        {
            get
            {
                WaitElement();
                return driver.FindElement(this.locator).Size;
            }
        }

        public string TagName
        {
            get
            {
                WaitElement();
                return driver.FindElement(this.locator).TagName;
            }
        }

        public string Text
        {
            get
            {
                WaitElement();
                return driver.FindElement(this.locator).Text;
            }
        }

        public void Clear()
        {
            WaitElement();
            driver.FindElement(this.locator).Clear();
        }

        public void Click()
        {
            Logger.Info(string.Concat(name," Click"));
            WaitElement();
            driver.FindElement(this.locator).Click();
        }

        public IWebElement FindElement()
        {
            WaitElement();
            return driver.FindElement(this.locator);
        }

        public ReadOnlyCollection<IWebElement> FindElements()
        {
            WaitElement();
            return driver.FindElements(this.locator);
        }

        public string GetAttribute(string attributeName)
        {
            WaitElement();
            return driver.FindElement(this.locator).GetAttribute(attributeName);
        }

        public string GetCssValue(string propertyName)
        {
            WaitElement();
            return driver.FindElement(this.locator).GetCssValue(propertyName);
        }

        public void SendKeys(string text)
        {
            WaitElement();
            Logger.Info(string.Concat(name, ":  SendKey ", text));
            driver.FindElement(this.locator).SendKeys(text);
        }

        public void Submit()
        {
            WaitElement();
            Logger.Info(string.Concat(name, ":  Submit"));
            driver.FindElement(this.locator).Submit();
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
