using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace BATDemoFramework
{
    public class Browser
    {
        private string baseUrl = "http://localhost:12142/";
        private IWebDriver webDriver;

        public Browser()
        {
            this.webDriver = new ChromeDriver();
        }

        public void Initialize()
        {
            Goto("");
        }

        public string Title
        {
            get { return webDriver.Title; }
        }

        public IWebDriver Driver
        {
            get { return webDriver; }
        }

        public void Goto(string url)
        {
            webDriver.Url = baseUrl + url;
        }

        public bool waitFor()
        {
            var wait = new WebDriverWait(this.webDriver, TimeSpan.FromSeconds(10));
            return wait.Until(CustomConditions.ElementIsVisibleCustom(By.Id("myId")));
        }

        internal IWebElement FindElement(By bySelect)
        {
            return this.webDriver.FindElement(bySelect);
        }

        public bool waitFor(Func<IWebDriver, Boolean> expectedCondition)
        {
            var wait = new WebDriverWait(this.webDriver, TimeSpan.FromSeconds(10));
            return wait.Until(expectedCondition);
        }

        public IWebElement waitFor(Func<IWebDriver, IWebElement> expectedCondition)
        {
            var wait = new WebDriverWait(this.webDriver, TimeSpan.FromSeconds(10));
            return wait.Until(expectedCondition);
        }

        public void Close()
        {
            //webDriver.Close();
        }
    }
}