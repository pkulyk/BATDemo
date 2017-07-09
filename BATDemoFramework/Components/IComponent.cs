using OpenQA.Selenium;
using OpenQA.Selenium.Internal;

namespace BATDemoFramework.Components
{
    interface IComponent : IWebElement, IWrapsElement, ILocatable 
    {
    }
}
