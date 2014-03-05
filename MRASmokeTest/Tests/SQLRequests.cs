using Generator.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.Tests.SQL
{
    public class SQL
    {
        List<string> sqlList;
        public List<string> SQLRequest(string collumnName, string sqlRequest)
        {
            using (SqlConnection connection = new SqlConnection(Settings.Default.LocalSqlConnection))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sqlRequest, connection);

                    using (var dataReader = cmd.ExecuteReader())
                    {
                        //var sqlList = (from IDataRecord r in dataReader select new { name = (string)r["SIM_Name"], type = (string)r["SIM_Type"] }).ToList();
                        sqlList = (from IDataRecord r in dataReader select (string)r[collumnName]).ToList();
                    }
                }
                finally
                {
                    connection.Close();
                }
                return sqlList;
            }
        }


        //Return all not archived  Ad-hock Simulations existed for current client
        public static string TC_AHS_10 = @"
        declare @clientName varchar(50)
        declare @simType varchar (50)

        set @clientName = 'TheHartford'
        set @simType = 'Ad Hoc'

        Select Sim.Name as SIM_Name, ST.Name as SIM_Type, Cl.Name as Client_Name

        from dbo.MRA_Simulation SIM
        inner join dbo.MRA_SimulationType ST 
        on Sim.SimulationTypeID = ST.SimulationTypeID
        inner join dbo.MRA_Patron Patron 
        on patron.PatronID = st.PatronID
        inner join dbo.ERC_Clients CL 
        on patron.PatronID = cl.PatronID and SIM.ClientId = cl.id

        where cl.Name = @clientName and St.Name = @simType and Sim.AuditArchiveDate is null
        order by SIM_Name ASC";


    }
}
