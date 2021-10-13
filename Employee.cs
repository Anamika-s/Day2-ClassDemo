 using System;
 internal class Employee
    {
        readonly int id;
        string name;
        static string dept;
        int salary;
        public const string companyName="UST" ;
        public  void GetDetails()
        {
Console.WriteLine("Enter ID");
id= Convert.ToByte(Console.ReadLine());
Console.WriteLine("Enter Name");
name = Console.ReadLine();
// Console.WriteLine("Enter Department");
// dept = Console.ReadLine();
Console.WriteLine("Enter Salary");
salary = Convert.ToInt16(Console.ReadLine());
}
public void DisplayDetails()
 {
Console.WriteLine("ID is " + id);
Console.WriteLine("Name is " + name);
// Console.WriteLine("Department is " + dept);
Console.WriteLine("Salary is " + salary);
 }
 public static void DepartmentDetails()
 {
   dept="HR";
   // name="";
     Console.WriteLine("Dept is " +  dept);
 }
  }