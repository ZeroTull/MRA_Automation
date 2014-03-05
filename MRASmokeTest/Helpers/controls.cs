using SmokeTest;
using OpenQA.Selenium;
using NUnit.Framework;
using Concrete;
using OpenQA.Selenium.Firefox;



namespace Helpers
{
    public class ControlHelpers
    {
        private IWebDriver driver;

        public ControlHelpers(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SelectWorkingVersionFromDataVersionDropdown()
        {
            ExpandSelectDataVersionDropdown();
            FindAndClickElement("html/body/div[7]/div/ul/li[2]");
            Logger.Trace("Working view is selected.");
        }
        public void SelectProductionViewFromDataVersionDropdown()
        {
            ExpandSelectDataVersionDropdown();
            FindAndClickElement("html/body/div[7]/div/ul/li[1]");
            Logger.Trace("Production view is selected.");
        }
        public void ExpandSelectDataVersionDropdown()
        {
            DropDownControl dropDown = new DropDownControl(driver, By.XPath("html/body/div[2]/div[3]/div/table/tbody/tr/td[1]/table/tbody/tr[1]/td[2]/form/span/span"));
            dropDown.expandDropDown(By.XPath("html/body/div[2]/div[3]/div/table/tbody/tr/td[1]/table/tbody/tr[1]/td[2]/form/span/span"));
        }
        public void ExpandDNISControl()
        {
            DropDownControl dropDown = new DropDownControl(driver, By.XPath("//span[@aria-activedescendant='CurrentClient_option_selected']"));
            dropDown.expandDropDown(By.XPath("html/body/div[2]/div[3]/div/table/tbody/tr/td[1]/table/tbody/tr[2]/td[2]/form/span/span/span[2]/span"));
        }
        public void ExpandClientDropdown()
        {
            DropDownControl dropDown = new DropDownControl(driver, By.XPath("//span[@aria-activedescendant='CurrentClient_option_selected']"));
            dropDown.expandDropDown(By.XPath("html/body/div[1]/div[1]/div/div/div[2]/div[1]/form/span/span"));
        }//TODO - to check
        public void SelectHartfordFromDropdown()
        {
            DropDownControl dropDown = new DropDownControl(driver, By.XPath("//span[@aria-activedescendant='CurrentClient_option_selected']"));
            dropDown.selectElementByValue(By.XPath("//li[.='TheHartford']")); 
            Logger.Trace("The Hartford client is selected.");
        } //Прикручен внешний контрол
        public void NavigateToSite()
        {
            //Set default URL
            string baseUrl = "http://lab-dev-04.lab-eng.com/MRA_DEV/Account/SelectClient";

            //Navigate to the site
            driver.Navigate().GoToUrl(baseUrl);
            Logger.Trace(@"http://lab-dev-04.lab-eng.com/MRA_DEV/Account/SelectClient page is opened.");
        }

        public void FindAndClickElement(string xpath)
        {
            driver.FindElement(By.XPath(xpath)).Click();
        }
        public bool IsElementPresent(string xpath)
        {
            var element = driver.FindElement(By.XPath(xpath));
            bool result = element != null;
            Logger.Trace("Element " + xpath + " is on the page.");
            return result;

        }
        public bool VerifiyElementValue(string xpath, string equalText)
        {
            var element = driver.FindElement(By.XPath(xpath));
            var attribute = driver.FindElement(By.XPath(xpath)).GetAttribute("value");
            string name = driver.FindElement(By.XPath(xpath)).GetAttribute("title");
            Assert.NotNull(attribute);
            bool result = false;
            if (element != null)
            {
                Assert.IsNotNullOrEmpty(attribute);
                if (!string.IsNullOrEmpty(attribute))
                {
                    result = string.Compare(attribute, equalText) == 0;
                    Assert.IsTrue(result);
                }
            }
            Logger.Trace("Element's '" + name + "' value equals " + equalText + " value.");
            return result;
        }
        public bool VerifiyElementText(string xpath, string equalText)
        {
            var element = driver.FindElement(By.XPath(xpath));
            string name = driver.FindElement(By.XPath(xpath)).Text; //GetAttribute("text");
            Assert.NotNull(element.Text);
            bool result = false;
            if (element != null)
            {
                Assert.IsNotNullOrEmpty(element.Text);
                if (!string.IsNullOrEmpty(element.Text))
                {
                    result = string.Compare(element.Text, equalText) == 0;
                    Assert.IsTrue(result);
                }
            }
            Logger.Trace("Element " + name + " text equals " + "'" + equalText + "'" + " value.");
            return result;
        }

        

        //КОСТЫЛЬ
        public void throwNoSuchElementException(string text)
        {
            throw new NoSuchElementException(text);
        }
    }

}
