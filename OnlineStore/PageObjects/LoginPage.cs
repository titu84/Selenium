using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
namespace OnlineStore.PageObjects
{
    public class LoginPage
    {
        private readonly IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "topBarLogin")]
        public IWebElement UserName { get; set; }
        [FindsBy(How = How.Id, Using = "topBarPassword")]
        public IWebElement Password { get; set; }
        [FindsBy(How = How.Id, Using = "topBar_LoginBtn")]
        public IWebElement Submit { get; set; }
    }
}
