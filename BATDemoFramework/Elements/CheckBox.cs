using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace BATDemoFramework.Elements
{
    public class CheckBox : Element
    {
        public CheckBox(Browser browser, By by) : base(browser, by)
        {
        }

        public void Check()
        {
            if(getWebElement().Selected)
                return;
            Click();
        }

        public void Uncheck()
        {
            if (getWebElement().Selected)
                Click();
            return;
        }

        public bool IsSelected()
        {
            return getWebElement().Selected;
        }
    }
}
