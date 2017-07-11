using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATDemoFramework.PageObjects
{
    public static class Pages
    {
        public static LoginPage LoginPage { get { return new LoginPage(Browser.Driver); } }

    }
}
