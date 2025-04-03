using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GSQA.Automation
{
    public static class DriverFactory
    {
        private static IWebDriver _driver;

        public static IWebDriver GetDriver()
        {
            if (_driver == null)
            {
                var options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                _driver = new ChromeDriver(options);
            }
            return _driver;
        }

        public static void QuitDriver()
        {
            _driver?.Quit();
            _driver = null;
        }
    }
}
