namespace ConsoleApp.Models
{
    public class Person
    {
       public string FullName { get; set; }
       public string Address { get; set; } 
       public int Age { get; set; }
       public void EnterData()
       {
        System.Console.Write("Full name = ");
        FullName = Console.ReadLine();
        System.Console.Write("Address = ");
        Address = Console.ReadLine();
        System.Console.Write("Age = ");
        Age = Convert.ToInt16(Console.ReadLine());
       }
       public void Display()
       {
        System.Console.WriteLine("Ten: {0} - Dia chỉ: {1} - {2} tuoi",FullName, Address, Age);
       }
    }
}