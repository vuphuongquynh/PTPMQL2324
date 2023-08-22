namespace ConsoleApp.Models
{
    public class Fruit
    {
        public string FruitID { get; set; }
       public string FruitName { get; set; } 
       public int Han { get; set; }
       public void EnterData()
       {
        System.Console.Write("Ma = ");
        FruitID = Console.ReadLine();
        System.Console.Write("Ten  = ");
        FruitName = Console.ReadLine();
        System.Console.Write("Ngay san xuat = ");
        Han = Convert.ToInt16(Console.ReadLine());
       }
        public void Display()
       {
        System.Console.WriteLine("Ma: {0} - Ten: {1} - Ngay san xuat: {2} ngay",FruitID, FruitName, Han);
       }
    }
}