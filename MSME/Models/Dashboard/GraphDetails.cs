using System.Data.SqlClient;
using System.Data;
using MSME.Models.Common;

namespace MSME.Models.Dashboard
{
    public class GraphDetails
    {

        public string? Fk_GeoLevelId { get; set; }

        public string? Level { get; set; }
        public string? GeoLevel { get; set; }
        public string? Type { get; set; }
        public string? AddedBy { get; set; }
        public string? filename { get; set; }
        public List<XAxis>? XAxisList { get; set; }
        public List<YAxis>? YAxisList { get; set; }
        public string? SheetName { get; set; }
        public string? Category { get; set; }

        public DataSet GetDashboardData()
        {
            SqlParameter[] para =
            {
                new SqlParameter("@Category",Category),
                new SqlParameter("@Level",Level),

            };
            DataSet ds = Connection.ExecuteQuery("GetDashboardData", para);
            return ds;
        }


    }
    public class XAxis
    {
        public string? Name { get; set; }
        public string? ShortName { get; set; }
        public string? LGDCode { get; set; }


    }
    public class XAxis1
    {
        public List<XAxis>? List1 { get; set; }

    }
    public class YAxis
    {
        public string? Attribute1 { get; set; }
        public string? Attribute2 { get; set; }
        public string? Value { get; set; }
    }
}
