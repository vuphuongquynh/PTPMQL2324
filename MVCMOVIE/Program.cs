using MVCMOVIE.Models;
public class Program
{
    private static void Mail(string[] args)
    {
       Person ps1 = new Person();
       Person ps2 = new Person();

       ps1.FullName = "Nguyen Van A";
       ps1.Address = "Ha Noi";
       ps1.Age = "18";

       ps1.Display();
    }
}