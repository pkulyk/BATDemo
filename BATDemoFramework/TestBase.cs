using NUnit.Framework;

namespace BATDemoFramework
{
    [TestFixture]
    public class TestBase
    {
        private Browser browser;

        [TestFixtureSetUp]
        public void Initialize()
        {
            this.browser = new Browser();
            browser.Initialize();
            //UserGenerator.Initialize();
        }        

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
            
        }

        [TearDown]
        public void TearDown()
        {
            //if(Pages.TopNavigation.IsLoggedIn())
            //    Pages.TopNavigation.LogOut();

            //if(UserGenerator.LastGeneratedUser != null)
            //    Browser.Goto("Account/DeleteUsers.cshtml");
        }
    }
}
