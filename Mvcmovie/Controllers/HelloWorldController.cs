using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace Mvcmovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //Get: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }
        //Get: /HelloWorld/Welcome/
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
