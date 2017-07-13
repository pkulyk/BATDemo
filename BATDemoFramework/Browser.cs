using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BATDemoFramework
{
    public class Browser
    {
        private static string baseUrl = "http://localhost:12142/";
        private static IWebDriver webDriver = new ChromeDriver();
        public void Initialize()
        {
            Goto("");
        }

        public string Title
        {
            get { return webDriver.Title; }
        }

        public IWebDriver Driver
        {
            get { return webDriver; }
        }

        public void Goto(string url)
        {
            webDriver.Url = baseUrl + url;
        }

        public void Close()
        {
            //webDriver.Close();
        }
    }
}