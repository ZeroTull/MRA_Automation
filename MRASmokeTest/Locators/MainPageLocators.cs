using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locators
{
    public class MainPageButtonsLocators
    {
        public const string replicateDNISButton = "html/body/div[2]/div[3]/div/table/tbody/tr/td[2]/table/tbody/tr[1]/td[3]/input";
        public const string saveChangesButton = "html/body/div[2]/div[3]/div/table/tbody/tr/td[2]/table/tbody/tr[2]/td[3]/input";
        public const string simulationButton = "html/body/div[2]/div[3]/div/table/tbody/tr/td[2]/table/tbody/tr[1]/td[4]/input";
        public const string searchAndReplaceButton = "html/body/div[2]/div[3]/div/table/tbody/tr/td[2]/table/tbody/tr[2]/td[4]/input";
        public const string importTemplateButton = "html/body/div[2]/div[3]/div/table/tbody/tr/td[2]/table/tbody/tr[1]/td[2]/div/div/div/input";
        public const string exportTemplateButton = "html/body/div[2]/div[3]/div/table/tbody/tr/td[2]/table/tbody/tr[2]/td[2]/input";
    }
    public class MainPageDropDownsLocators
    {
        public const string clientDropDown = "html/body/div[1]/div[1]/div/div/div[2]/div[1]/form/span/span/span[1]";
        public const string dnisDropDown = "html/body/div[2]/div[3]/div/table/tbody/tr/td[1]/table/tbody/tr[2]/td[2]/form/span/span/span[1]";
        public const string dataVersionDropDown = "html/body/div[2]/div[3]/div/table/tbody/tr/td[1]/table/tbody/tr[1]/td[2]/form/span/span";
        public const string productionView = "html/body/div[7]/div/ul/li[1]";
        public const string workingView = "html/body/div[7]/div/ul/li[2]";
    }
    public class MainPageSearchFieldLocators
    {
        public const string searchInputField = "html/body/div[2]/div[3]/div/div[1]/div/div[1]/div/div/div[1]/div/div[1]/input";
        public const string searchButton = "html/body/div[2]/div[3]/div/div[1]/div/div[1]/div/div/div[1]/div/div[4]/a[1]";
        public const string leftSearchButton = "html/body/div[2]/div[3]/div/div[1]/div/div[1]/div/div/div[1]/div/div[4]/a[3]";
        public const string rightSearchButton = "html/body/div[2]/div[3]/div/div[1]/div/div[1]/div/div/div[1]/div/div[4]/a[2]";
    }
    public class MainPageTreeLocators
    {
        public const string tree = "html/body/div[2]/div[3]/div/div[1]/div/div[1]/div/div/div[2]";
        public const string masterDefaultRoteNode = "html/body/div[2]/div[3]/div/div[1]/div/div[1]/div/div/div[2]/div/ul/li[1]/div/span[3]";

    }
}