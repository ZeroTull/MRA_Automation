using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;

namespace SmokeTest
{
    class DropDownControl
    {
        private IWebDriver driver;
        private By mainLocator;

        public DropDownControl(IWebDriver driver, By dropDownLocator)
        {
            this.driver = driver;
            mainLocator = dropDownLocator;
        }

        public void selectElementByValue(By valueLocator)
        {
            IWebElement we = driver.FindElement(mainLocator);
            we.Click();
            Thread.Sleep(1000);

            var elem = we.FindElement(valueLocator);
            elem.Click();
            //driver.FindElement(valueLocator).Click();
        }
        public void expandDropDown(By mainLocator)
        {
            driver.FindElement(mainLocator).Click();
        }

    }
}
