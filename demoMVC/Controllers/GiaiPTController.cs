using System.Reflection.PortableExecutable;
using Microsoft.AspNetCore.Mvc;
namespace demoMVC.Controllers;
public class GiaiptController : Controller
{
    public IActionResult Giaipt()
   {
     return View();
   }
   [HttpPost]
public IActionResult Giaipt(string hesoA, string hesoB, string hesoC)
{
    //khai bao bien
    double delta, x1, x2, a =0, b =0, c =0;
    string Ketqua;
    //Giai phuong trinh
    if(!String.IsNullOrEmpty(hesoA)) a = Convert.ToDouble(hesoA);
    if(!String.IsNullOrEmpty(hesoB)) a = Convert.ToDouble(hesoB);
    if(!String.IsNullOrEmpty(hesoC)) a = Convert.ToDouble(hesoC);
    if(a==0) Ketqua = " Khong phai phuong trinh bac 2";
    else{
        //tinh delta
        delta = Math.Pow(b,2) - 4*a*c;
        //giai phuong trinh
        if(delta<0) Ketqua = "Phuong trinh vo nghiem";
        else if(delta==0)
        {
            x1 = -b/(2*a);
            Ketqua = " Phuong trinh co nghiem kep = " + x1;
        }
        else
        {
            x1= (-b + Math.Sqrt(delta))/(2*a);
            x2= (-b - Math.Sqrt(delta))/(2*a);
            Ketqua = " Phuong trinh co 2 nghiem phan biet: x1= "+ x1 + ",x2= "+x2; 
        }
    }
    ViewBag.Giaipt = Ketqua;
        return View();
}
}