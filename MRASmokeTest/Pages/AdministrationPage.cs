using Abstract;
using Helpers;
using Locators;
using OpenQA.Selenium;

namespace concrete
{
    public class AdministrationPage : AbstractPage
    {
        public AdministrationPage(IWebDriver driver) :
            base(driver)
        {
            controls = new ControlHelpers(driver);
        }

        private ControlHelpers controls;

        //Base methods
        public void navigateToAdministrationPage()
        {
            controls.FindAndClickElement(HeaderLocators.AdministrationPage);
        }
    }
}
