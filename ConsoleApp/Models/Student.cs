namespace ConsoleApp.Models
{
     public class Student : Person
    {
        public string StudentCode {get; set;}
    public void EnterData()
    {
        //ke thua lai o class Person
        base.EnterData();
        // nhap thong tin student code
        System.Console.Write("Student Code = ");
        StudentCode = Console.ReadLine();
    }
    public void Display()
    {
        //Ke thua class Person
        base.Display();
        //Nhap thong tin Student code
        System.Console.Write("Ma sinh vien: {0}", StudentCode);
    }
    }
}