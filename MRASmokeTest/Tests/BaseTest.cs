using concrete;
using Concrete;
using Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace Generator.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;
        protected ControlHelpers controls;

        [SetUp]
        public void Setup()
        {
            driver = new InternetExplorerDriver(@"D:\Selenium");// FirefoxDriver();
            controls = new ControlHelpers(driver);
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }

        public MainPage MainPage
        {
            get
            {
                return new MainPage(driver);
            }
        }

        public AdministrationPage AdministrationPage
        {
            get
            {
                return new AdministrationPage(driver);
            }
        }

        public SimulationPage SimulationPage
        {
            get
            {
                return new SimulationPage(driver);
            }
        }


    }
}
