using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locators
{
    public class SimulationsPageTabLocators
    {
        public const string HistoricalSimulationsTab = "html/body/div[2]/div[3]/div/div/ul/li[1]/a";
        public const string MultipleSimulationsTab = "html/body/div[2]/div[3]/div/div/ul/li[2]/a";
    }

    public class HistoricalSimulationsLocators
    {
        public const string SavedSimulationsDropdown = "html/body/div[2]/div[3]/div/div/div[1]/div[1]/div[1]/fieldset/div/span[2]/span";
        public const string StartDateMenu = "html/body/div[2]/div[3]/div/div/div[1]/div[1]/div[3]/fieldset/table/tbody/tr/td[1]/span/span/span/span";
        public const string StartDateField = "html/body/div[2]/div[3]/div/div/div[1]/div[1]/div[3]/fieldset/table/tbody/tr/td[1]/span/span/input";
        public const string EndDateMenu = "html/body/div[2]/div[3]/div/div/div[1]/div[1]/div[3]/fieldset/table/tbody/tr/td[3]/span/span/span/span";
        public const string EndDateField = "html/body/div[2]/div[3]/div/div/div[1]/div[1]/div[3]/fieldset/table/tbody/tr/td[3]/span/span/input";
        public const string DNISClearAll = "html/body/div[2]/div[3]/div/div/div[1]/div[1]/div[3]/fieldset/div[1]/fieldset/input";
        public const string INTENTClearAll = "html/body/div[2]/div[3]/div/div/div[1]/div[1]/div[3]/fieldset/div[2]/fieldset/input";
        public const string DestinationClearAll = "html/body/div[2]/div[3]/div/div/div[1]/div[1]/div[3]/fieldset/div[3]/fieldset/input";
        public const string FlagClearAll = "html/body/div[2]/div[3]/div/div/div[1]/div[1]/div[3]/fieldset/div[4]/fieldset/input";
        public const string SaveAllChanges = "html/body/div[2]/div[3]/div/div/div[1]/div[1]/div[3]/fieldset/div[6]/fieldset/input[3]";
        public const string RetrieveRecords = "html/body/div[2]/div[3]/div/div/div[1]/div[1]/div[3]/fieldset/div[6]/fieldset/input[3]";
        public const string Execute = "html/body/div[2]/div[3]/div/div/div[1]/div[1]/div[5]/fieldset/div/div[1]/div/table/thead/tr/th[5]/a";
        public const string WorkindVersionCheckBox = "html/body/div[2]/div[3]/div/div/div[1]/div[1]/div[3]/fieldset/div[6]/fieldset/label[2]/input";
        public const string ProductionVersionCheckBox = "html/body/div[2]/div[3]/div/div/div[1]/div[1]/div[3]/fieldset/div[6]/fieldset/label[3]/input";
    }

}