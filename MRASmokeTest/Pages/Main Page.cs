using OpenQA.Selenium;
using Abstract;
using Helpers;
using Locators;
using OpenQA.Selenium.Firefox;


namespace Concrete
{
    public class MainPage : AbstractPage
    {
        public MainPage(IWebDriver driver)
            : base(driver)
        {
            controls = new ControlHelpers(driver);
        }

        private ControlHelpers controls;


        //Base methods
        public void NavigateToMainPage()
        {
            controls.NavigateToSite();
        }

        //Tree view 
        public void clickMasterDefaultRouteNode()
        {
            driver.FindElement(By.XPath(MainPageTreeLocators.masterDefaultRoteNode));
        }

        //Search
        public void selectSearchField()
        {
            driver.FindElement(By.XPath(MainPageSearchFieldLocators.searchInputField)).Click();
        }
        public void clickSearchButton()
        {
            driver.FindElement(By.XPath(MainPageSearchFieldLocators.searchButton)).Click();
        }



    }



}
