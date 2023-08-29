namespace ConsoleApp.Models
{
    public class Employee
    {
       public string EmployeeID { get; set; }
       public string EmployeeName { get; set; } 
       public int EmployeeAge { get; set; }
       public int Luong { get; set; }
       public void EnterData()
       {
        System.Console.Write("Ma nhan vien = ");
        EmployeeID = Console.ReadLine();
        System.Console.Write("Ten nhan vien = ");
        EmployeeName = Console.ReadLine();
        System.Console.Write("Tuoi = ");
        EmployeeAge = Convert.ToInt16(Console.ReadLine());
        System.Console.Write("Luong = ");
        Luong = Convert.ToInt16(Console.ReadLine());
        try{
            //câu lệnh có thể gây ngoại lệ
            Luong = Convert.ToInt16(Console.ReadLine());
        }catch(Exception e)
        {
            //câu lệnh xử lý ngoại lệ
            Luong = 0;
        }
       }
        public void Display()
       {
        System.Console.WriteLine("Ma nhan vien: {0} - Ten nhan vien: {1} - Tuoi: {2} - Luong {3}",EmployeeID, EmployeeName, EmployeeAge, Luong);
       }
    }
}