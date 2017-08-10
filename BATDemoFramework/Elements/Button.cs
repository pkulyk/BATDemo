using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace BATDemoFramework.Elements
{
    public class Button : Element
    {
        public Button(Browser browser, By by) : base(browser, by)
        {
        }

        new public void Click()
        {
            getWebElement().Click();
        }
    }
}
