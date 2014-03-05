// Smoke test set for MRA site.
// Author Chervanev Dmitry;
// Date of creation - 08.08.2013.

using System;
using NUnit.Framework;
using OpenQA.Selenium;
using Abstract;
using Helpers;
using Locators;
using OpenQA.Selenium.Firefox;
using Generator.Tests;

namespace SmokeTest
{
    [TestFixture]
    public class SmokeTest : BaseTest
    {
        
        [Test]
        public void TC_S_01_VerifyThatMRAMainPageIsDisplayed()
        {
            string testName = "TC_S_01 - Verify That MRA Main Page Is Displayed";
            Logger.StepIn(testName);
            Reporter.Path = string.Format(@"D:\{0}_{1}.txt", testName, DateTime.Now.ToString("dd.MM.yyyy HH-mm-ss"));
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
          
            #region Variables to set expected values for elements titles names.
            var replicateDNISButtonName = "Replicate DNIS";
            var saveChangesButtonName = "Save changes";
            var simulationButtonName = "Simulation";
            var searchAndReplaceButtonName = "Search and Replace";
            var importTemplateButtonName = "Import Template";
            var exportTemplateButtonName = "Export Template";
            var searchFieldDefaultText = "Type text to search on tree…";
            #endregion
            
            //Main body of the test
            controls.NavigateToSite();
            controls.SelectHartfordFromDropdown();
            //Verify if Select Client Dropdown is on the page
            Assert.IsTrue(controls.IsElementPresent(MainPageDropDownsLocators.clientDropDown));
            //Verify DNIS dropdown
            Assert.IsTrue(controls.IsElementPresent(MainPageDropDownsLocators.dnisDropDown));
            //Verify if all appropriate buttons are presented on the page
            Assert.IsTrue(controls.VerifiyElementValue(MainPageButtonsLocators.replicateDNISButton, replicateDNISButtonName));
            Assert.IsTrue(controls.VerifiyElementValue(MainPageButtonsLocators.saveChangesButton, saveChangesButtonName));
            Assert.IsTrue(controls.VerifiyElementValue(MainPageButtonsLocators.simulationButton, simulationButtonName));
            Assert.IsTrue(controls.VerifiyElementValue(MainPageButtonsLocators.searchAndReplaceButton, searchAndReplaceButtonName));
//            Assert.IsTrue(controls.VerifiyElementText(MainPageButtonsLocators.importTemplateButton, importTemplateButtonName));
            Assert.IsTrue(controls.VerifiyElementValue(MainPageButtonsLocators.exportTemplateButton, exportTemplateButtonName));
            //Verify if field for MRA tree is presented on the page
            Assert.IsTrue(controls.IsElementPresent(MainPageTreeLocators.tree));
            //Verify if tree contain 'Master default Route' node
            Assert.IsTrue(controls.IsElementPresent(MainPageTreeLocators.masterDefaultRoteNode));
            //Verify if 'Master default Route' node has 'Master default Route' title. 
            if (controls.IsElementPresent(MainPageTreeLocators.masterDefaultRoteNode))//TODO
                {
                    string name = driver.FindElement(By.XPath(MainPageTreeLocators.masterDefaultRoteNode)).Text;
                    Assert.IsTrue(string.Compare(name, "Master Default Route") == 0);
                    Logger.Trace(@"Master default Route node has 'Master default Route' title.");
                }
                    else
                        controls.throwNoSuchElementException(@"There is no 'Master default Route' node on the page.");
            //Verify if search field is on the page
            Assert.IsTrue(controls.IsElementPresent(MainPageSearchFieldLocators.searchInputField));
            //verify search field default text
            if (controls.IsElementPresent(MainPageSearchFieldLocators.searchInputField))
                {
                    string name = driver.FindElement(By.XPath(MainPageSearchFieldLocators.searchInputField)).GetAttribute("placeholder");
                    Assert.IsTrue(string.Compare(name, searchFieldDefaultText) == 0);
                    Logger.Trace("Search field contains " + searchFieldDefaultText + " text.");
                }
                    else
                        throw new NoSuchElementException(@"There is no 'Master default Route' node on the page.");
            //Verify that search button is on the page
            Assert.IsTrue(controls.IsElementPresent(MainPageSearchFieldLocators.searchButton));
            Logger.TestDone();
        } // 08/10/2013 test is working stable.

        [Test]
        public void TC_S_02_VerifyDataVersionSelector()
        {
            string testName = "TC_S_02 - Verify Data Version Selector";
            Logger.StepIn(testName);
            Reporter.Path = string.Format(@"D:\{0}_{1}.txt", testName, DateTime.Now.ToString("dd.MM.yyyy HH-mm-ss"));
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            controls.NavigateToSite();
            controls.SelectHartfordFromDropdown();
            //Verify that 'Select Data Version' selector is displayed.
            if (controls.IsElementPresent(MainPageDropDownsLocators.dataVersionDropDown))
            //Expand data selector dropdown
            controls.ExpandSelectDataVersionDropdown();
            //Verify element 'Production View - Read only' ant it's text.
            Assert.IsTrue(controls.VerifiyElementText(MainPageDropDownsLocators.productionView, "Production View - Read only"));
            //Verify element 'Hartford - Working Version' ant it's text.
            Assert.IsTrue(controls.VerifiyElementText(MainPageDropDownsLocators.workingView, "Hartford - Working Version"));
            //Select 'Hartford - Working Version' from dropdown.
            controls.FindAndClickElement(MainPageDropDownsLocators.workingView);
            Logger.TestDone();
        } //23.09.2013 test is working stable.
        [Test]
        public void TC_S_03_VerifyPrimaryKeyDropdown()
        {
            string testName = "TC_S_03 - VerifyPrimaryKeyDropdown";
            Logger.StepIn(testName);
            Reporter.Path = string.Format(@"D:\{0}_{1}.txt", testName, DateTime.Now.ToString("dd.MM.yyyy HH-mm-ss"));
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            controls.NavigateToSite();
            controls.SelectHartfordFromDropdown();
            // Check Primary Key (DNIS) control - Primary Key (DNIS) combo box is displayed.
            Assert.IsTrue(controls.IsElementPresent(MainPageDropDownsLocators.dnisDropDown));
            //Expand Primary Key (DNIS) Dropdown 
            controls.ExpandDNISControl();
            //List of Primary Keys is expanded.
            Assert.IsTrue(controls.IsElementPresent("html/body/div[8]/div"));
            //Select any non cureent DNIS.
            controls.FindAndClickElement("html/body/div[8]/div/ul/li[7]");
            //Page is reloaded to display Tree Working View for selected PK (DNIS).
            Assert.IsTrue(controls.VerifiyElementText(MainPageDropDownsLocators.dnisDropDown, "1000006"));
            //TODO напиздячить проверку наличия списка.

            //TODO напиздячить выбор рандомного элемента из dropdown списка.
            Logger.TestDone();
        } //TODO проверки прикручены, но мне не нравится как они выполнены. 
        [Test]
        public void TS_S_04()
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            controls.NavigateToSite();
            controls.SelectHartfordFromDropdown();
            //Change Select Data Version Dropdown to Working View
            controls.ExpandSelectDataVersionDropdown();
            //Select working version
            controls.FindAndClickElement(MainPageDropDownsLocators.workingView);
            Assert.IsTrue(controls.IsElementPresent(MainPageTreeLocators.tree));
            //expand DNIS dropdown
            controls.FindAndClickElement(MainPageDropDownsLocators.dnisDropDown);
            //Get value of the selected menu item
            var index = driver.FindElement(By.XPath("html/body/div[8]/div/ul/li[8]")).Text;  //GetAttribute("tabindex");
            //Select menu item
            controls.FindAndClickElement("html/body/div[8]/div/ul/li[8]");
            //Get value of DNIS on the opened page 
            var DNIS = driver.FindElement(By.XPath(MainPageDropDownsLocators.dnisDropDown)).Text;
            //Compare two values of the elements to approve new page load 
            Assert.IsTrue(string.Compare(index, DNIS) == 0);
            
            //Check that tree view is displayed at the left side of page
            Logger.TestDone();
        }//Not completed
    }
}