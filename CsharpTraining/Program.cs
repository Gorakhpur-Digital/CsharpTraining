using System;
using System.Collections.Generic;
using System.Linq;

public delegate void SumOfCallBackDelegate(int sum);
class Program
{
    public static void Main()
    {
        List<Employee> employees = new List<Employee>() { 
           new Employee { Id = 101, Name = "Arvind"},
           new Employee { Id = 102, Name = "Abhay"},
           new Employee { Id = 103, Name = "Akash"},
           new Employee { Id = 104, Name = "Vivek"},
        };
        //Func<Employee, string> selector = emp => "Name = " + emp.Name;
        //IEnumerable<string> names =  employees.Select(selector);

        IEnumerable<string> names = employees.Select(emp => "Name = " + emp.Name) ;

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}

