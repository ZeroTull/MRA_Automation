using Abstract;
using Helpers;
using Locators;
using OpenQA.Selenium;

namespace Concrete
{
    public class SimulationPage : AbstractPage
    {
        public SimulationPage(IWebDriver driver):
            base(driver)
        {
            controls = new ControlHelpers(driver);    
        }
                
        private ControlHelpers controls;

        public void NavigateToSimulationsPage()
        {
            controls.FindAndClickElement(HeaderLocators.SimulationsPage);
        }
        public void SelectHistoricalSimulationsTab()
        {
            controls.FindAndClickElement(SimulationsPageTabLocators.HistoricalSimulationsTab);
        }
        public void SelectMultipleSimulationsTab()
        {
            controls.FindAndClickElement(SimulationsPageTabLocators.MultipleSimulationsTab);
        }
    }
}
