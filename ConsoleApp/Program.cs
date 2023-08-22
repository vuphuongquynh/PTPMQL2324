using ConsoleApp.Models;
public class Program
{
    private static void Main(string[] args)
    {
        //khoi tao 2 doi tuong thu class Person
        Person ps1 = new Person();
        Person ps2 = new Person();
        //gan gia tri cho thuoc tinh doi tuong ps1
        ps1.FullName = "Nguyen Van A";
        ps1.Address = "Ha Noi";
        ps1.Age = 18;
        //goi phuong thuc thuc hien thi thong tin
        ps1.Display();
    }
}