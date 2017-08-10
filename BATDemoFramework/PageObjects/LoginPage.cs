using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using BATDemoFramework.Elements;

namespace BATDemoFramework.PageObjects
{
    public class LoginPage : BasePage
    {
        private TextBox emailAddressTextField;
        private TextBox passwordTextField;
        private Button logInButton;

        public LoginPage(Browser browser) : base(browser)
        {
            this.emailAddressTextField = new TextBox(browser, By.Id("email"));
            this.passwordTextField = new TextBox(browser, By.Id("password"));
            this.logInButton = new Button(browser, By.CssSelector("input[type='submit']"));
        }

        public Button LoginButton { get { return this.logInButton; } }

        public void Login(string email, string password)
        {
            this.emailAddressTextField.TypeText(email);
            this.passwordTextField.TypeText(password);
            this.logInButton.Click();
        }
    }
}
