﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace BATDemoFramework.Elements
{
    public class TextBox : Element
    {
        public TextBox(Browser browser, By by) : base(browser, by)
        {
        }

        public void TypeText(string text)
        {
            getWebElement().SendKeys(text);
        }
    }
}
