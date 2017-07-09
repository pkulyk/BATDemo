using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions.Internal;
using OpenQA.Selenium.Internal;

namespace BATDemoFramework.Components
{
    class ComponentImpl : IComponent
    {
        private IWebElement element;

        public ComponentImpl(IWebElement element)
        {
            this.element = element;
        }

        string IWebElement.TagName => this.element.TagName;

        string IWebElement.Text => this.element.Text;

        bool IWebElement.Enabled => this.element.Enabled;

        bool IWebElement.Selected => this.element.Selected;

        Point IWebElement.Location => this.element.Location;

        Size IWebElement.Size => this.element.Size;

        bool IWebElement.Displayed => this.element.Displayed;

        IWebElement IWrapsElement.WrappedElement => throw new NotImplementedException();

        Point ILocatable.LocationOnScreenOnceScrolledIntoView => throw new NotImplementedException();

        ICoordinates ILocatable.Coordinates => throw new NotImplementedException();

        void IWebElement.Clear()
        {
            this.element.Clear();
        }

        void IWebElement.Click()
        {
            this.element.Click();
        }

        IWebElement ISearchContext.FindElement(By by)
        {
            return this.element.FindElement(by);
        }

        ReadOnlyCollection<IWebElement> ISearchContext.FindElements(By by)
        {
            return this.element.FindElements(by);
        }

        string IWebElement.GetAttribute(string attributeName)
        {
            return this.element.GetAttribute(attributeName);
        }

        string IWebElement.GetCssValue(string propertyName)
        {
            return this.element.GetCssValue(propertyName);
        }

        void IWebElement.SendKeys(string text)
        {
            this.element.SendKeys(text);
        }

        void IWebElement.Submit()
        {
            this.element.Submit();
        }
    }
}
