using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using CsharpTraining.Bl;
using CsharpTraining.Model;

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
        //Predicate<Employee> employeePredicate = new Predicate<Employee>(FindEmployee);
        //Employee emp =  employees.Find(delegate(Employee emp) { return emp.Id == 103; });
        Employee emp = employees.Find(emp => emp.Id == 101);

        Console.WriteLine("Id = {0} Name = {1}", emp.Id, emp.Name);

        //bool FindEmployee(Employee emp)
        //{
        //    return emp.Id == 102;
        //}



    }
}

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}

