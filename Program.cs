using System;

namespace Project1
{
  
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company Name is" + Employee.Company);
           // Employee.dept="HR";
        
           // int x, y ,z;
        //   Employee employee1 =  new Employee();
        //   employee1.GetDetails();
        //   employee1.DisplayDetails();
        //     Employee employee2 =  new Employee();
        //   employee2.GetDetails();
        //   employee2.DisplayDetails();
        //     Employee employee3 =  new Employee();
        //   employee3.GetDetails();
        //   employee3.DisplayDetails();
// Array of Objects
        Employee[] employees = new  Employee[10];
        for(int i=0;i<3;i++)
        {
            employees[i] = new  Employee();
            employees[i].GetDetails();
        }
        Employee.DepartmentDetails();
       for(int i=0;i<3;i++)
        {
            
            employees[i].DisplayDetails();
        }











        }
    }
}
