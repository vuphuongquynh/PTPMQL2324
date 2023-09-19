using Microsoft.AspNetCore.Mvc;
namespace TESTMVC.Controllers;
public class DemoController : Controller
    {
        public ActionResult Index()
        {
            return View(); 
        }
        [HttpPost]

        public ActionResult Index(string fname)
        {
            ViewBag.mes = " Xin chao " + fname;
            return View(); 
        }
    }