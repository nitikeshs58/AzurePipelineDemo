using AzurePipelineDemo.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AzurePipelineDemo.TestDemo
{
    [TestFixture]
    public class CITest
    {
        public IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.linkedin.com/login";
        }

        [Test,Order(1)]
        public void LoginTest()
        {
            LoginPage page = new LoginPage(driver);
            page.LoginMetod();
        }

        [TearDown]
        public void TearDownMethod()
        {
            driver.Quit();
        }
    }
}
