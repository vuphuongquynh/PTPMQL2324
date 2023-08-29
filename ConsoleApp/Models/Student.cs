namespace ConsoleApp.Models
{
     public class Student : Fruit
    {
        public string hsd {get; set;}
    public void EnterData()
    {
        //ke thua lai o class Person
        base.EnterData();
        // nhap thong tin student code
        System.Console.Write("Han Su Dung = ");
        hsd = Console.ReadLine();
    }
    public void Display()
    {
        //Ke thua class Person
        base.Display();
        //Nhap thong tin Student code
        System.Console.Write("Han Su Dung: {0}", hsd);
    }
    }
}