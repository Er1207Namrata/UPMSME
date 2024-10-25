using Microsoft.AspNetCore.Mvc;

namespace MSME.Areas.admin.Controllers
{
    [Area("admin")]
    public class MasterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Majoractivity()
        {
            return View(); 
        }


        public IActionResult Organizationtype()

        {
            return View();
        }
    }
}
