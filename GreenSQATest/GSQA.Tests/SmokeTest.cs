using Xunit;
using OpenQA.Selenium;
using GSQA.Automation;

namespace GSQA.Tests
{
    public class SmokeTest
    {
        [Fact]
        public void ShouldOpenGoogle()
        {
            IWebDriver driver = DriverFactory.GetDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            Assert.Contains("Google", driver.Title);
            DriverFactory.QuitDriver();
        }
    }
}
