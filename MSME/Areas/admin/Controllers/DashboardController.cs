
using Microsoft.AspNetCore.Mvc;
using MSME.Models.Common;
using MSME.Models.Dashboard;
using System.Data;
using System.Diagnostics;
using System.Net;
using System.Xml.Linq;

namespace MSME.Areas.admin.Controllers
{
    [Area("admin")]
    public class DashboardController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public ActionResult BindAllDivisionsMap(string Category, string Level,string Fk_DivisionId, string LGDCode)
        {
            GraphDetails graphDetails = new GraphDetails();
            DataSet dataSet = new DataSet();

            if (string.IsNullOrEmpty(Fk_DivisionId) || Fk_DivisionId == "0")
            {
                graphDetails.Level = "AllDivision";
            }
            graphDetails.Category = Category;
            dataSet = graphDetails.GetDashboardData();
            List<YAxis> listB = new List<YAxis>();
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                
                graphDetails.GeoLevel = "";

                for (int i = 0; i <= dataSet.Tables[0].Rows.Count - 1; i++)
                {
                    YAxis listdata = new YAxis();
                    listdata.Attribute1 = dataSet.Tables[0].Rows[i]["D_LGD"].ToString();
                    listdata.Attribute2 = dataSet.Tables[0].Rows[i]["Name"].ToString();
                    listdata.Value = dataSet.Tables[0].Rows[i]["TotalCount"].ToString();

                    listB.Add(listdata);
                }

            }

            graphDetails.YAxisList = listB;

            #region MapJson
            var APIurl = "";
            if (graphDetails.Level == "SINGLEDISTRICT")
            {
                APIurl = "https://uphealthfacility.in/api/Webapi/GetDistrictDivisionJson?ZoneId=" + LGDCode;
            }
            else if (graphDetails.Level == "BLOCK")
            {
                APIurl = "https://uphealthfacility.in/api/Webapi/GetBlockByDistrictJson?DistrictId=" + LGDCode;
            }
            else if (graphDetails.Level == "TEHSIL")
            {
                APIurl = "https://uphealthfacility.in/api/Webapi/GetTahshilJson?DistrictId=" + LGDCode;
            }
            else
            {
                APIurl = "https://uphealthfacility.in/api/Webapi/GetZoneJson";

            }

            #region
            var result = "";

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(APIurl);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            #endregion
            graphDetails.filename = DateTime.Now.ToString("ddmmyyyyhhmmss");




            string path = MapPath.Path + graphDetails.filename + ".json";

            if (System.IO.Directory.Exists(MapPath.Path))
            {
                System.IO.Directory.Delete(MapPath.Path, true);
            }
            System.IO.Directory.CreateDirectory(MapPath.Path);
            System.IO.File.Create(path).Close();
            System.IO.File.WriteAllText(path, result);



            #endregion
            return Json(graphDetails);
        }
       

    }
}
