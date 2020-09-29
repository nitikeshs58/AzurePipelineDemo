using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using FindsByAttribute = SeleniumExtras.PageObjects.FindsByAttribute;

namespace AzurePipelineDemo.Pages
{
    public class LoginPage
    {
        public IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement Userid;

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement Password;

        [FindsBy(How = How.XPath, Using = "//button[@type = 'submit']")]
        public IWebElement SignIn;

        public void LoginMetod()
        {
            Userid.SendKeys("nitikeshs58@gmail.com");
            Password.SendKeys("pass8390");
            SignIn.Click();
        }
    }
}
