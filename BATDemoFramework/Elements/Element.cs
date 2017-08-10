using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATDemoFramework.Elements
{
    public class Element
    {
        private Browser browser;
        private By bySelect;
        Func<IWebDriver, Boolean> waitStrategy;

        public Element(Browser browser, By by)
        {
            this.browser = browser;
            this.bySelect = by;
        }

        public Element(Browser browser, By by, Func<IWebDriver, Boolean> waitStrategy)
        {
            this.browser = browser;
            this.bySelect = by;
            this.waitStrategy = waitStrategy;
        }

        public IWebElement getWebElement()
        {
            return this.browser.FindElement(this.bySelect);
        }

        public void Click()
        {
            
            this.getWebElement().Click();
        }

        protected IWebElement getChild(By by)
        {
            return this.getWebElement().FindElement(by);
        }

        protected List<IWebElement> getChildren(By by)
        {
            var elements = this.getWebElement().FindElements(by);

            return elements.Count > 0 ? elements.ToList() : new List<IWebElement>();
        }
    }
}
