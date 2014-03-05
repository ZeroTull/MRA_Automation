using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locators
{
    class AdHocMenuLocators
    {
        public const string adHocSimMenuName = "//span[@id='simulationWindow_wnd_title']";
        public const string nameOfNewSimulationField = "//input[@id='newNameTextBox']";
        public const string SimulationName = "//input[@id='newNameTextBox']";

        //Buttons
        public const string createSimulationButton = "//input[@id='adHocCreateSimulation']";
        public const string cancelCreationOfSimulationButton = "//input[@id='adHocCreateSimulationCancel']";
        public const string saveChangesButton = "//input[@id='adHocSaveChanges']";
        public const string saveNewSimulationButton = "//input[@id='adHocSaveNewSimulation']";
        public const string saveAsButton = "//input[@id='adHocSaveAsNewSimulation']";
        public const string addFlagButton = "//input[@id='adHocAddFlag']";
        public const string removeSelectedButton = "//input[@id='adHocRemoveFlag']";
        public const string executeButton = "//input[@id='adHocExecute']";
        public const string cancelButton = "input[@id='adHocCancel']";
        public const string deleteButton = "//input[@id='deleteAdHocSimulation']";

        //Dropdowns
        public const string nameDropdown = "//span[@aria-owns='SimulationName_listbox']/span/span[@class='k-input']";
        public const string nameDropdownList = "html/body/div[11]/div";
        public const string primaryKeyDropdown = "//span[@aria-owns='firstKeyList_listbox']/span";
        public const string secondaryKeyDropdown = "//span[@aria-owns='secondKeyList_listbox']/span";
        public const string titleOfSimulationDropdown = "//td[@class='fieldTitleWidth150']/div[2]";
        public const string primaryKeyDropdownName = "//span[@data-bind='text: PkFirstPartName']";
        public const string secondaryKeyDropdownName = "//span[@data-bind='text: PkSecondPartName']";
        public const string itemsPerPageDropdown = "html/body/div[10]/div[2]/div[1]/div[1]/div[1]/div[3]/span[1]/span/span"; //"//span[@class='k-pager-sizes k-label']//span[contains(text(),'5')]";
        public const string fiveItemsPerPage = "//div[14]/div/ul/li[1]";
        public const string tenItemsPerPage = "//div[14]/div/ul/li[2]";
        public const string twentyItemsPerPage = "//div[14]/div/ul/li[3]";
        
        //Flags grid
        public const string selectAllCheckBox = "html/body/div[10]/div[2]/div[1]/div[1]/div[1]/div[1]/div/table/thead/tr/th[1]/input";
        public const string flagTypeCollumnHeader = "html/body/div[10]/div[2]/div[1]/div[1]/div[1]/div[1]/div/table/thead/tr/th[2]/a";
        public const string flagCollumnHeader = "html/body/div[10]/div[2]/div[1]/div[1]/div[1]/div[1]/div/table/thead/tr/th[3]/a";
        public const string settingCollumnHeader = "html/body/div[10]/div[2]/div[1]/div[1]/div[1]/div[1]/div/table/thead/tr/th[4]/a";
        public const string editCollumnHeader = "html/body/div[10]/div[2]/div[1]/div[1]/div[1]/div[1]/div/table/thead/tr/th[5]";
        
        //Navigation panel
        public const string toTheFirstPage = "html/body/div[10]/div[2]/div[1]/div[1]/div[1]/div[3]/a[1]/span";
        public const string toTheLastPage = "html/body/div[10]/div[2]/div[1]/div[1]/div[1]/div[3]/a[4]/span";
        public const string toThePreviousPage = "html/body/div[10]/div[2]/div[1]/div[1]/div[1]/div[3]/a[2]/span";
        public const string toTheNextPage = "html/body/div[10]/div[2]/div[1]/div[1]/div[1]/div[3]/a[3]/span";
        public const string currentPage = "html/body/div[10]/div[2]/div[1]/div[1]/div[1]/div[3]/ul/li/span";

        //Delete Pop up

        public const string DeleteButtonOnDeletePopup = "html/body/div[18]/div[2]/div[3]/input";
        public const string CancelButtonOnDeletePopup = "html/body/div[18]/div[2]/div[2]/input";
        public const string CloseButtonOnDeleteResultPopup = "html/body/div[18]/div[2]/div/input";
    } 
}
