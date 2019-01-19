using NUnit.Framework;
using OnlineStore.PageObjects;
using SeleniumDemo;
namespace OnlineStore.TestCases
{
    [TestFixture]
    public class LogInTest : MainTest
    {
        private readonly string _login = "wsei_test";
        private readonly string _password = "wsei_test";
        [Test]
        public void LoginTest()
        {
            _driver.Url = "https://chomikuj.pl";
            var homePage = new HomePage(_driver);
            homePage.MyAccount.Click();
            var loginPage = new LoginPage(_driver);
            loginPage.UserName.SendKeys(_login);
            loginPage.Password.SendKeys(_password);
            loginPage.Submit.Submit();
            Assert.IsTrue(homePage.HeaderText.Displayed);
           // StringAssert.Equals("Chomik o takiej nazwie nie istnieje", homePage.HeaderText.Text);
        }
    }
}