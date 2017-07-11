using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace BATDemoFramework.Elements
{
    public class TextBox : Element
    {
        public TextBox(IWebDriver driver, By by) : base(driver, by)
        {
        }

        public void TypeText(string text)
        {
            getWebElement().SendKeys(text);
        }
    }
}
