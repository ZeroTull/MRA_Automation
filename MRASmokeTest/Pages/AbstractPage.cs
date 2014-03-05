using Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Abstract
{
    public class AbstractPage
    {
        private TimeSpan IMPLICITLY_GENERAL_WAIT_VISIBILITY_OF_ELEMENT_SEC = new TimeSpan(30);
        protected IWebDriver driver;

        public AbstractPage(IWebDriver driver)
        {
            this.driver = driver;
        }
     
        public IWebElement GetElement(By locator)
        {
            return new WebDriverWait(this.driver, IMPLICITLY_GENERAL_WAIT_VISIBILITY_OF_ELEMENT_SEC)
                    .Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public IWebElement GetSubElement(By sourceLocator, By destinationLocator)
        {

            List<IWebElement> elements = GetElement(sourceLocator)
                                        .FindElements(destinationLocator).ToList();

            //TODO change to return elements.FirstOfDefault();
            return elements.Count > 0 ? elements[0] : null;
        }

        public void TypeWithClear(string text, By locator)
        {
            Logger.Trace("    Field " + locator.ToString() + " is " + text);

            IWebElement el = GetElement(locator);
            el.Clear();
            el.SendKeys(text);
        }

        /// <param name="state" may be "0" or "1"></param>
        public void SetCheckBox(string state, By loc)
        {
            Logger.Trace("    Checkbox " + loc.ToString() + " is " + state);

            IWebElement element = GetElement(loc);
            SetCheckBox(state, element);
        }

        public void SetCheckBox(string state, IWebElement element)
        {
            Logger.Trace("    Checkbox " + element.ToString() + " is " + state);

            if ((element.Selected && string.Compare(state, "0", true) == 0)
                    || (!element.Selected && string.Compare(state, "1", true) == 0))
            {
                element.Click();
            }
        }

        public void SetRadioButton(string state, By loc)
        {
            Logger.Trace("    Radiobtn " + loc.ToString() + " is " + state);

            GetElement(loc).FindElement(By.XPath("../input[@value='" + state + "']")).Click();
        }

        public void SetText(By by, String text)
        {
            Logger.Trace("SetText: " + by.ToString() + " --> "+ text);
            IWebElement element = GetElement(by);
            SetText(element, text);
        }

        public void Click(By by)
        {
            Logger.Trace("Element " + by.ToString() + " is being clicked.");

            GetElement(by).Click();
        }

        private void SetText(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        //public void sendKeys(By by, Keys key)
        //{
        //    GetElement(by).SendKeys(key.ToString());//TODO CHECK THIS
        //    Logger.Trace("Send Keys: elem -> " + by.ToString()+ ", key -> " + key.ToString());
        //}

        public bool IsPresent(By by)
        {
            List<IWebElement> elements = driver.FindElements(by).ToList();
            return elements.Count > 0;
        } ///////??????????

        public bool IsPresent(By locator, long waitSec)
        {
            bool res = false;
            try
            {
                driver.Manage().Timeouts()
                        .ImplicitlyWait(new TimeSpan(waitSec));
                res = driver.FindElements(locator).Count > 0;
            }
            catch (Exception e)
            {
                // TODO add error text :gmartov
            }
            finally
            {
                driver.Manage()
                        .Timeouts()
                        .ImplicitlyWait(IMPLICITLY_GENERAL_WAIT_VISIBILITY_OF_ELEMENT_SEC);
            }

            return res;
        }///////?????????

        public bool IsPresent(IWebElement element)
        {
            return string.IsNullOrEmpty(element.Text);
        }//////////////????????????

        public void CloseAlert(bool accept)
        {
            IAlert alert;
            try
            {
                alert = driver.SwitchTo().Alert();
            }
            catch (Exception e)
            {
                return;
            }
            if (alert != null)
            {
                try
                {
                    if (string.Compare(alert.Text, "false") != 0)//check
                    {
                        if (accept)
                            alert.Accept();
                        else
                            alert.Dismiss();
                    }
                }
                catch (WebDriverException e)
                {
                    Debug.WriteLine("Alert isn't present");
                }
            }
        }

        public bool IsTextPresent(string text)
        {
            return driver.PageSource.Contains(text);
        }

        public void SelectFromDropdownByValue(By by, string value)
        {
            Logger.Trace("Select from dropdown: " + by.ToString() + " --> " + value);

            IWebElement element = GetElement(by);
            SelectElement dropdown = new SelectElement(element);

            dropdown.SelectByValue(value);
        }

        public void SelectFromDropdownByText(By by, string text)
        {
            Logger.Trace("Select from dropdown: " + by.ToString() + " --> " + text);

            IWebElement element = GetElement(by);

            SelectElement dropdown = new SelectElement(element);
            dropdown.SelectByText(text);
        }

        public List<string> getAllDropownValues(By by)
        {
            Logger.StepIn("Get a list of all dropdown values");

            List<string> values = new List<string>();
             IWebElement element = GetElement(by);
            SelectElement dropdown = new SelectElement(element);
            List<IWebElement> elements = dropdown.Options.ToList();

            for (int i = 0; i < elements.Count(); i++)
            {
                values.Add(elements[i].GetAttribute("value"));
                Logger.Trace(elements[i].GetAttribute("value"));
            }

            Logger.StepOut();
            return values;
                       
        }

    }
}
