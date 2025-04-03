using OpenQA.Selenium;

namespace GSQA.Automation.Pages
{
    public class HomePage
    {
        private readonly IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        private By originInput => By.Id("fsb-origin--text-field");
        private By destinationInput => By.Id("fsb-destination--text-field");
        private By departureDateInput => By.Id("fsb-departure--text-field");
        private By returnDateInput => By.Id("fsb-return--text-field");
        private By searchButton => By.Id("fsb-search-flights");

        public void EnterOrigin(string origin)
        {
            _driver.FindElement(originInput).SendKeys(origin);
            _driver.FindElement(By.XPath("//div//p[@class='sc-eldPxv jDETuo latam-typography latam-typography--paragraph-base sc-fPXMVe iZqZog']//strong")).Click();

            
        }

        public void EnterDestination(string destination)
        {
            _driver.FindElement(destinationInput).SendKeys(destination);
            _driver.FindElement(By.XPath("//div//p[@class='sc-eldPxv jDETuo latam-typography latam-typography--paragraph-base sc-fPXMVe iZqZog']//strong")).Click();

        }

        public void SetDepartureDate()
        {
            _driver.FindElement(departureDateInput).Click();
            _driver.FindElement(By.XPath("//div//span[@id='date-2025-04-15']")).Click();
        }

        public void SetReturnDate()
        {
            
            _driver.FindElement(returnDateInput).Click();
            _driver.FindElement(By.XPath("//div//span[@id='date-2025-04-16']")).Click();
        }

        public void SetReturnMinusDate()
        {

            _driver.FindElement(returnDateInput).Click();
            _driver.FindElement(By.XPath("//div//span[@id='date-2025-04-14']")).Click();

        }
        public void ClickSearch()
        {
            _driver.FindElement(searchButton).Click();
        }

        public void SearchFlight(string origin, string destination)
        {
            EnterOrigin(origin);
            EnterDestination(destination);
            SetDepartureDate();
            SetReturnDate();
            ClickSearch();
        }
        
        
    }
}
