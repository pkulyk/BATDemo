using BATDemoFramework;
using BATDemoFramework.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATDemoTests
{
    [TestFixture]
    public class NewTests : TestBase
    {
        [Test]
        public void NewLoginTest()
        {

            Pages.LoginPage.LoginButton.Click();

        }

    }
}
