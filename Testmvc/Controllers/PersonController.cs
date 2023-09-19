using Microsoft.AspNetCore.Mvc;
using TESTMVC.Models;

namespace TESTMVC.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Person ps)
        {
            ViewBag.ps = "Thông tin là "  + ps.PersonName + "-" + ps.PersonID + "-" + ps.PersonAddress;
            return View();
        }
    }
}