
using System.Data;
using System.Data.SqlClient;
using MSME.Models.Common;

namespace MSME.Models.Dashboard
{
    public class Dashboard
    {
        public string? Level { get; set; }
        public string? LgdCode { get; set; }
        public DataSet GetLevelFromLgdCode()
        {
            DataSet dataSet = new DataSet();
            SqlParameter[] para =
            {
                new SqlParameter("@LgdCode",LgdCode),
                new SqlParameter("@Level",Level)
            };
            dataSet = Connection.ExecuteQuery("GetLevelFromLgdCode", para);
            return dataSet;
        }
    }
}
