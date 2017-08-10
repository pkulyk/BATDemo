using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATDemoFramework
{
    public static class CustomConditions
    {


        public static Func<IWebDriver, Boolean> ElementIsVisibleCustom(By locator)
        {
            return (d =>
                {
                    var element = d.FindElement(locator);
                    return false;
                }
            );
        }
    }
}
