using System;
using System.Collections.Generic;
using CsharpTraining.Bl;
using CsharpTraining.Model;

class Program
{
    public static void Main()
    {
        List<Employee> empList = new List<Employee>();

        empList.Add(new Employee()
        {
            EmployeeId = 1,
            Name = "Arvind",
            MobileNo = "1234567"
        });

        empList.Add(new Employee()
        {
            EmployeeId = 2,
            Name = "Abhay",
            MobileNo = "9876543"
        });

        empList.Add(new Employee()
        {
            EmployeeId = 3,
            Name = "Vishal",
            MobileNo = "37654329"
        });

        //Employee e =  empList[1];
        //Console.WriteLine(e.Name);

        Console.WriteLine("{0} {1} {2}", empList[0].EmployeeId, empList[0].Name, empList[0].MobileNo);

        

    }

}

class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public string MobileNo { get; set; }
}