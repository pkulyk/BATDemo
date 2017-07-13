using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATDemoFramework.PageObjects
{
    public abstract class BasePage
    {
        private IWebDriver driver;

        public BasePage(Browser browser)
        {
            this.driver = browser.Driver;
        }

        protected IWebDriver Driver { get { return this.driver; } }

        //public void GoTo(string uri)
        //{
        //    this.
        //}

    }
}
