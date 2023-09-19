using Microsoft.AspNetCore.Mvc;
namespace TESTMVC.Controllers;
public class TinhluongController : Controller
    {
        public IActionResult Tinhluong()
        {
            return View(); 
        }
        [HttpPost]

        public IActionResult Tinhluong(string Luongcb, string Heso, string Phucap)
        {
            double lcb =0, hs =0, pc =0, luong =0;
            string trave;
            if(!String.IsNullOrEmpty(Luongcb)) lcb = Convert.ToDouble(Luongcb);
            if(!String.IsNullOrEmpty(Heso)) hs = Convert.ToDouble(Heso);
            if(!String.IsNullOrEmpty(Phucap)) pc = Convert.ToDouble(Phucap);
            luong = lcb*hs+pc;
            trave = "Lương của bạn là: " + luong;
           ViewBag.tl = trave;
            return View(); 
        }
    }