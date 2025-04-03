using Xunit;
using OpenQA.Selenium;
using GSQA.Automation;
using GSQA.Automation.Pages;

namespace GSQA.Tests
{
    public class FlightSearchTest
    {
        [Fact]
        public void ShouldSearchRoundTripFlights()
        {
            // Inicializar navegador
            IWebDriver driver = DriverFactory.GetDriver();
            driver.Navigate().GoToUrl("https://www.latamairlines.com");

            // Crear instancia del PageObject
            var homePage = new HomePage(driver);

            string origin = "Bogotá, BOG - Colombia";
            string destination = "Cali, CLO - Colombia";


            // Ejecutar flujo
            homePage.SearchFlight(origin, destination);

            // Aquí podrías agregar una validación si hay resultados
            // Por ahora asumimos que se navega correctamente

            // Cerrar navegador
            DriverFactory.QuitDriver();
        }
    [Fact]
    public void ShouldShowErrorForInvalidReturnDate()
    {
        IWebDriver driver = DriverFactory.GetDriver();
        driver.Navigate().GoToUrl("https://www.latamairlines.com");

        var homePage = new HomePage(driver);


        string origin = "Bogotá, BOG - Colombia";
        string destination = "Cali, CLO - Colombia";

        homePage.SearchFlight(origin, destination);

        // Esperar respuesta o validación visual
        

        DriverFactory.QuitDriver();
    }

[Fact]
public void ShouldShowValidationMessagesWhenFieldsAreEmpty()
{
    IWebDriver driver = DriverFactory.GetDriver();
    driver.Navigate().GoToUrl("https://www.latamairlines.com");

    var homePage = new HomePage(driver);

    // No llenamos nada
    homePage.ClickSearch();

    // Verificamos que el sistema muestre validaciones (ajustar según HTML real)
    // Ejemplo: mensaje "Campo obligatorio", clases CSS de error, etc.
    

    DriverFactory.QuitDriver();
}

    }
}
