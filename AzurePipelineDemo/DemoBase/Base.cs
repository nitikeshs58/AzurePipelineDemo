using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AzurePipelineDemo.DemoBase
{
    [TestFixture]
    public class Base
    {
        public IWebDriver driver = new ChromeDriver();

        [OneTimeSetUp]
        public void Initialize()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.linkedin.com/login";
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }       
}
