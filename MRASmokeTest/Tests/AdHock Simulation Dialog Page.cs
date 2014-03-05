// AdHock Simulation Dialog page for MRA site.
// Author Chervanev Dmitry;
// Date of creation - 18.11.2013.

using System;
using NUnit.Framework;
using Abstract;
using Helpers;
using Locators;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Firefox;
using Generator.Tests;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Generator.Tests.SQL;


namespace AdHocSimulationDialogPage
{
    [TestFixture]
    public class AdHocSimulationDialogPageTest : BaseTest
    {
        [Test]
        public void TC_AHS_01_VerifyThatSimulationButtonIsDisplayedOnMainPage()
        {
            string testName = "TC_AHS_01_VerifyThatSimulationButtonIsDisplayedOnMainPage";
            Logger.StepIn(testName);
            Reporter.Path = string.Format(@"D:\{0}_{1}.txt", testName, DateTime.Now.ToString("dd.MM.yyyy HH-mm-ss"));
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            controls.NavigateToSite();
            controls.SelectHartfordFromDropdown();
            Assert.IsTrue(controls.IsElementPresent(MainPageButtonsLocators.simulationButton));
            Logger.TestDone();
        }
        [Test]
        public void TC_AHS_02_VerifyThatSimulationButtonIsDisplayedInWorkingView()
        {
            string testName = "TC_AHS_02_VerifyThatSimulationButtonIsDisplayedInWorkingView";
            Logger.StepIn(testName);
            Reporter.Path = string.Format(@"D:\{0}_{1}.txt", testName, DateTime.Now.ToString("dd.MM.yyyy HH-mm-ss"));
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            controls.NavigateToSite();
            controls.SelectHartfordFromDropdown();

            controls.FindAndClickElement(MainPageDropDownsLocators.dataVersionDropDown);
            controls.FindAndClickElement(MainPageDropDownsLocators.workingView);
            Assert.IsTrue(controls.IsElementPresent(MainPageButtonsLocators.simulationButton));

            Logger.TestDone();
        }
        [Test]
        public void TC_AHS_03_VerifyThatAdhocSimulationDialogIsDisplayedOnClickSimulation()
        {
            string testName = "TC_AHS_03_VerifyThatAdhocSimulationDialogIsDisplayedOnClickSimulation";
            Logger.StepIn(testName);
            Reporter.Path = string.Format(@"D:\{0}_{1}.txt", testName, DateTime.Now.ToString("dd.MM.yyyy HH-mm-ss"));
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            controls.NavigateToSite();
            controls.SelectHartfordFromDropdown();
            controls.FindAndClickElement(MainPageDropDownsLocators.dataVersionDropDown);
            controls.FindAndClickElement(MainPageDropDownsLocators.workingView);
            controls.FindAndClickElement(MainPageButtonsLocators.simulationButton);
            Assert.IsTrue(controls.IsElementPresent("html/body/div[10]"));

            Logger.TestDone();
        }
        [Test]
        public void TC_AHS_04_VerifyThatSimulationNameComboBoxIsDisplayedOnAdhocSimulationDialog()
        {
            string testName = "TC_AHS_04_VerifyThatSimulationNameComboBoxIsDisplayedOnAdhocSimulationDialog";
            Logger.StepIn(testName);
            Reporter.Path = string.Format(@"D:\{0}_{1}.txt", testName, DateTime.Now.ToString("dd.MM.yyyy HH-mm-ss"));
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            controls.NavigateToSite();
            controls.SelectHartfordFromDropdown();
            controls.FindAndClickElement(MainPageDropDownsLocators.dataVersionDropDown);
            controls.FindAndClickElement(MainPageDropDownsLocators.workingView);
            controls.FindAndClickElement(MainPageButtonsLocators.simulationButton);
            Assert.IsTrue(controls.IsElementPresent(AdHocMenuLocators.nameDropdown));
            controls.VerifiyElementText(AdHocMenuLocators.titleOfSimulationDropdown, "Name:");
            Logger.TestDone();
        }
        [Test]
        public void TC_AHS_05_VerifyThatSimulationsListIsDisplayedOnClickNameCombobox()
        {
            string testName = "TC_AHS_05_VerifyThatSimulationsListIsDisplayedOnClickNameCombobox";
            Logger.StepIn(testName);
            Reporter.Path = string.Format(@"D:\{0}_{1}.txt", testName, DateTime.Now.ToString("dd.MM.yyyy HH-mm-ss"));
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            controls.NavigateToSite();
            controls.SelectHartfordFromDropdown();
            controls.FindAndClickElement(MainPageDropDownsLocators.dataVersionDropDown);
            controls.FindAndClickElement(MainPageDropDownsLocators.workingView);
            controls.FindAndClickElement(MainPageButtonsLocators.simulationButton);
            Assert.IsTrue(controls.IsElementPresent(AdHocMenuLocators.nameDropdown));
            controls.FindAndClickElement(AdHocMenuLocators.nameDropdown);
            Assert.IsTrue(controls.IsElementPresent(AdHocMenuLocators.nameDropdownList));
            Logger.TestDone();
        }
        [Test]
        public void TC_AHS_06_VerifyThatSimulationNameItemIsSelectedFromDropdown()
        {
            string testName = "TC_AHS_06_VerifyThatSimulationNameItemIsSelectedFromDropdown";
            Logger.StepIn(testName);
            Reporter.Path = string.Format(@"D:\{0}_{1}.txt", testName, DateTime.Now.ToString("dd.MM.yyyy HH-mm-ss"));
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            controls.NavigateToSite();
            controls.SelectHartfordFromDropdown();
            controls.FindAndClickElement(MainPageDropDownsLocators.dataVersionDropDown);
            controls.FindAndClickElement(MainPageDropDownsLocators.workingView);
            controls.FindAndClickElement(MainPageButtonsLocators.simulationButton);
            Assert.IsTrue(controls.IsElementPresent(AdHocMenuLocators.nameDropdown));
            controls.FindAndClickElement(AdHocMenuLocators.nameDropdown);
            Thread.Sleep(5);                                                                    //?????????????
            string name1 = driver.FindElement(By.XPath("html/body/div[11]/div/ul/li[2]")).Text;
            controls.FindAndClickElement("html/body/div[11]/div/ul/li[2]");
            string name2 = driver.FindElement(By.XPath(AdHocMenuLocators.nameDropdown)).Text;
            Assert.IsTrue(string.Compare(name1, name2) == 0);

            Logger.TestDone();
        }
        [Test]
        public void TC_AHS_07_VerifyThatSimulationAttributesAreRefreshedWhenChangeNameValue()
        {
            string testName = "TC_AHS_07_VerifyThatSimulationAttributesAreRefreshedWhenChangeNameValue";
            Logger.StepIn(testName);
            Reporter.Path = string.Format(@"D:\{0}_{1}.txt", testName, DateTime.Now.ToString("dd.MM.yyyy HH-mm-ss"));
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            controls.NavigateToSite();
            controls.SelectHartfordFromDropdown();
            controls.FindAndClickElement(MainPageDropDownsLocators.dataVersionDropDown);
            controls.FindAndClickElement(MainPageDropDownsLocators.workingView);
            controls.FindAndClickElement(MainPageButtonsLocators.simulationButton);
            Assert.IsTrue(controls.IsElementPresent(AdHocMenuLocators.nameDropdown));
            controls.FindAndClickElement(AdHocMenuLocators.nameDropdown);
            //Thread.Sleep(10);                                                               ///КОСТЫЛЬ!!!!!
            controls.FindAndClickElement("html/body/div[11]/div/ul/li[6]");
            controls.FindAndClickElement(AdHocMenuLocators.nameDropdown);
            string name1 = driver.FindElement(By.XPath("html/body/div[11]/div/ul/li[7]")).Text;
            controls.FindAndClickElement("html/body/div[11]/div/ul/li[7]");
            string name2 = driver.FindElement(By.XPath(AdHocMenuLocators.nameDropdown)).Text;
            Assert.IsTrue(string.Compare(name1, name2) == 0);

            Logger.TestDone();
        }
        [Test]
        public void TC_AHS_08_VerifyThatNewSimulationNameIsTypedToNameInputField()
        {
            string testName = "TC_AHS_08_VerifyThatNewSimulationNameIsTypedToNameInputField";
            Logger.StepIn(testName);
            Reporter.Path = string.Format(@"D:\{0}_{1}.txt", testName, DateTime.Now.ToString("dd.MM.yyyy HH-mm-ss"));
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            string textToSet = "" + Generator.RandomValuesGenerator.setRandomString(6) + "";

            controls.NavigateToSite();
            controls.SelectHartfordFromDropdown();
            controls.FindAndClickElement(MainPageDropDownsLocators.dataVersionDropDown);
            controls.FindAndClickElement(MainPageDropDownsLocators.workingView);
            controls.FindAndClickElement(MainPageButtonsLocators.simulationButton);
            controls.FindAndClickElement(AdHocMenuLocators.createSimulationButton);
            controls.FindAndClickElement(AdHocMenuLocators.nameOfNewSimulationField);
            MainPage.SetText(By.XPath(AdHocMenuLocators.nameOfNewSimulationField), textToSet);
            string name = driver.FindElement(By.XPath(AdHocMenuLocators.nameOfNewSimulationField)).GetAttribute("value");
            Assert.IsTrue(string.Compare(name, textToSet) == 0);

            Logger.TestDone();
        }
        [Test]
        public void TC_AHS_09_VerifyThatSimulationIsNotSavedWithEmptyName()
        {
            string testName = "TC_AHS_09_VerifyThatSimulationIsNotSavedWithEmptyName.";
            Logger.StepIn(testName);
            Reporter.Path = string.Format(@"D:\{0}_{1}.txt", testName, DateTime.Now.ToString("dd.MM.yyyy HH-mm-ss"));
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            string textToSet = "";

            controls.NavigateToSite();
            controls.SelectHartfordFromDropdown();
            controls.FindAndClickElement(MainPageDropDownsLocators.dataVersionDropDown);
            controls.FindAndClickElement(MainPageDropDownsLocators.workingView);
            controls.FindAndClickElement(MainPageButtonsLocators.simulationButton);
            controls.FindAndClickElement(AdHocMenuLocators.createSimulationButton);
            controls.FindAndClickElement(AdHocMenuLocators.nameOfNewSimulationField);
            MainPage.SetText(By.XPath(AdHocMenuLocators.nameOfNewSimulationField), textToSet);
            controls.FindAndClickElement(AdHocMenuLocators.saveNewSimulationButton);
            //Assert.IsTrue(controls.IsElementPresent());

            //Напедалить локатор попапа о невозможности сохранение симуляции с пустым именем


            Logger.TestDone();
        } //not completed
        [Test]
        public void TC_AHS_10_SQLVerifyThatAllExistedAdhocSimulationsAreDisplayedInSimulationNameList()
        {
            string testName = "TC_AHS_10_SQLVerifyThatAllExistedAdhocSimulationsAreDisplayedInSimulationNameList.";
            Logger.StepIn(testName);
            Reporter.Path = string.Format(@"D:\{0}_{1}.txt", testName, DateTime.Now.ToString("dd.MM.yyyy HH-mm-ss"));
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            SQL SQL = new SQL();

            controls.FindAndClickElement(MainPageDropDownsLocators.dataVersionDropDown);
            controls.FindAndClickElement(MainPageDropDownsLocators.workingView);
            controls.FindAndClickElement(MainPageButtonsLocators.simulationButton);
            controls.FindAndClickElement(AdHocMenuLocators.nameDropdown);

            List<string> siteList = driver.FindElements(By.XPath(AdHocMenuLocators.nameDropdown)).Select(x => x.Text).ToList();
            List<string> sqlList = SQL.SQLRequest("SIM_Name", SQL.TC_AHS_10); 
            
            // Вынести настройку коннекшена в аппконфиг !!!!!!!!!!!!!!!!!!!!!!!!!!!!! - вынес в стеттинки солюшена
            // Сделать отдельный метод для исполнения SQL запросов с параметрами: +
            // 1. сама выборка из класса SQLRequests 
            // 2. название выбираемого поля "sqlList"

            
            //using (SqlConnection connection = new SqlConnection(@"Data Source=W7EchopassMCC-3\sqlexpress;Initial Catalog=ERC;Integrated Security=True"))
            //{
            //    try
            //    {
            //        connection.Open();
            //        SqlCommand cmd = new SqlCommand(SQLRequests.TC_AHS_10, connection);
                    
            //        using (var dataReader = cmd.ExecuteReader())
            //        {
            //            //var sqlList = (from IDataRecord r in dataReader select new { name = (string)r["SIM_Name"], type = (string)r["SIM_Type"] }).ToList();
            //            sqlList = (from IDataRecord r in dataReader select (string)r["SIM_Name"]).ToList();
            //        }
            //    }
            //    finally
            //    {
            //        connection.Close();
            //    }
            //}

            Assert.IsTrue(siteList.Except(sqlList).Count() == 0);
        } //ДОДЕЛАТЬ!!!!!!!!!!!!! ПРОВЕРИТЬ!
        [Test]
        public void TC_AHS_11_VerifyThatJustAddedSimulationIsDisplayedInSimulationNameList()
        {
            string testName = "TC_AHS_11_VerifyThatJustAddedSimulationIsDisplayedInSimulationNameList.";
            Logger.StepIn(testName);
            Reporter.Path = string.Format(@"D:\{0}_{1}.txt", testName, DateTime.Now.ToString("dd.MM.yyyy HH-mm-ss"));
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            string textToSet = "" + Generator.RandomValuesGenerator.setRandomString(6) + "";
            controls.NavigateToSite();
            controls.SelectHartfordFromDropdown();

            controls.FindAndClickElement(MainPageDropDownsLocators.dataVersionDropDown);
            controls.FindAndClickElement(MainPageDropDownsLocators.workingView);
            controls.FindAndClickElement(MainPageButtonsLocators.simulationButton);
            controls.FindAndClickElement(AdHocMenuLocators.createSimulationButton);
            controls.FindAndClickElement(AdHocMenuLocators.nameOfNewSimulationField);
            MainPage.SetText(By.XPath(AdHocMenuLocators.nameOfNewSimulationField), textToSet);
            controls.FindAndClickElement(AdHocMenuLocators.primaryKeyDropdown);
            controls.FindAndClickElement("//ul[@id='firstKeyList_listbox']/li[text()='1000007']");
            controls.FindAndClickElement(AdHocMenuLocators.secondaryKeyDropdown);
            controls.FindAndClickElement("//ul[@id='secondKeyList_listbox']/li[14]");
            controls.FindAndClickElement(AdHocMenuLocators.saveNewSimulationButton);
            controls.FindAndClickElement(AdHocMenuLocators.nameDropdown);
            //Assert.IsTrue(MainPage.IsPresent(By.Name(textToSet)));
            driver.FindElement(By.XPath("//ul[@id='SimulationName_listbox']/li[text()='" + textToSet + "']")).Click();
            controls.FindAndClickElement(AdHocMenuLocators.deleteButton);
            controls.FindAndClickElement(AdHocMenuLocators.DeleteButtonOnDeletePopup);
            controls.FindAndClickElement(AdHocMenuLocators.CloseButtonOnDeleteResultPopup);
            Assert.IsTrue(controls.VerifiyElementText(AdHocMenuLocators.nameDropdown, "Select or create new..."));
            Logger.TestDone();
        }

    }
}